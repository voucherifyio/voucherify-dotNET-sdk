using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Voucherify.Test
{
    /// <summary>
    /// Authenticated HTTP helper for Loyalty v2 admin paths that are not published in the .NET SDK.
    /// Runtime member flows should use LV2*Api.
    /// </summary>
    public sealed class LoyaltyV2HttpException : Exception
    {
        public int Status { get; }
        public JsonElement? Body { get; }

        public LoyaltyV2HttpException(int status, string message, JsonElement? body = null)
            : base(message)
        {
            Status = status;
            Body = body;
        }
    }

    public static class LoyaltyV2Http
    {
        private static readonly HttpClient Http = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(120)
        };

        public static bool HasCredentials => TestConfiguration.HasClientCredentials;

        public static async Task<JsonElement> RequestAsync(
            string method,
            string path,
            object body = null,
            IDictionary<string, object> query = null)
        {
            EnsureCredentials();

            string url = BuildUrl(path, query);
            string upper = method.ToUpperInvariant();

            using var request = new HttpRequestMessage(new HttpMethod(upper), url);
            request.Headers.TryAddWithoutValidation("X-App-Id", TestConfiguration.AppId);
            request.Headers.TryAddWithoutValidation("X-App-Token", TestConfiguration.AppToken);
            request.Headers.TryAddWithoutValidation("Accept", "application/json");

            if (body != null && upper != "GET" && upper != "DELETE")
            {
                string json = body is string s
                    ? s
                    : body is JsonElement element
                        ? element.GetRawText()
                        : JsonSerializer.Serialize(body);
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            }
            else if (upper == "POST" || upper == "PUT" || upper == "PATCH")
            {
                request.Content = new StringContent("{}", Encoding.UTF8, "application/json");
            }

            HttpResponseMessage response;
            try
            {
                response = await Http.SendAsync(request).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw new LoyaltyV2HttpException(
                    0,
                    $"HTTP transport failed: {ex.Message}");
            }

            string text = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            JsonElement? data = ParseBody(text);

            int status = (int)response.StatusCode;
            if (status < 200 || status >= 300)
            {
                string excerpt = text == null
                    ? ""
                    : text.Length <= 500
                        ? text
                        : text.Substring(0, 500);
                throw new LoyaltyV2HttpException(
                    status,
                    $"Loyalty v2 HTTP {upper} {path} failed: {status} {excerpt}",
                    data);
            }

            return data ?? default;
        }

        public static Task<JsonElement> CreateProgram(object body) =>
            RequestAsync("POST", "/v2/loyalties/programs", body);

        public static Task<JsonElement> ActivateProgram(string programId) =>
            RequestAsync("POST", $"/v2/loyalties/programs/{programId}/activate");

        public static Task<JsonElement> DeactivateProgram(string programId) =>
            RequestAsync("POST", $"/v2/loyalties/programs/{programId}/deactivate");

        public static Task<JsonElement> DeleteProgram(string programId) =>
            RequestAsync("DELETE", $"/v2/loyalties/programs/{programId}");

        public static Task<JsonElement> CreateCardDefinition(object body) =>
            RequestAsync("POST", "/v2/loyalties/card-definitions", body);

        public static Task<JsonElement> ActivateCardDefinition(string cardDefinitionId) =>
            RequestAsync("POST", $"/v2/loyalties/card-definitions/{cardDefinitionId}/activate");

        public static Task<JsonElement> DeleteCardDefinition(string cardDefinitionId) =>
            RequestAsync("DELETE", $"/v2/loyalties/card-definitions/{cardDefinitionId}");

        public static Task<JsonElement> CreateEarningRule(object body) =>
            RequestAsync("POST", "/v2/loyalties/earning-rules", body);

        public static Task<JsonElement> ActivateEarningRule(string earningRuleId) =>
            RequestAsync("POST", $"/v2/loyalties/earning-rules/{earningRuleId}/activate");

        public static Task<JsonElement> DeactivateEarningRule(string earningRuleId) =>
            RequestAsync("POST", $"/v2/loyalties/earning-rules/{earningRuleId}/deactivate");

        public static Task<JsonElement> DeleteEarningRule(string earningRuleId) =>
            RequestAsync("DELETE", $"/v2/loyalties/earning-rules/{earningRuleId}");

        public static Task<JsonElement> CreateReward(object body) =>
            RequestAsync("POST", "/v2/loyalties/rewards", body);

        public static Task<JsonElement> ActivateReward(string rewardId) =>
            RequestAsync("POST", $"/v2/loyalties/rewards/{rewardId}/activate");

        public static Task<JsonElement> DeactivateReward(string rewardId) =>
            RequestAsync("POST", $"/v2/loyalties/rewards/{rewardId}/deactivate");

        public static Task<JsonElement> DeleteReward(string rewardId) =>
            RequestAsync("DELETE", $"/v2/loyalties/rewards/{rewardId}");

        public static Task<JsonElement> BatchAssignCardDefinitions(string programId, object body) =>
            RequestAsync("POST", $"/v2/loyalties/programs/{programId}/card-definitions/batch", body);

        public static Task<JsonElement> BatchAssignEarningRules(string programId, object body) =>
            RequestAsync("POST", $"/v2/loyalties/programs/{programId}/earning-rules/batch", body);

        public static Task<JsonElement> BatchAssignRewards(string programId, object body) =>
            RequestAsync("POST", $"/v2/loyalties/programs/{programId}/rewards/batch", body);

        public static string Id(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Object &&
                element.TryGetProperty("id", out JsonElement id) &&
                id.ValueKind == JsonValueKind.String)
            {
                return id.GetString();
            }

            return null;
        }

        private static void EnsureCredentials()
        {
            if (!HasCredentials)
            {
                throw new InvalidOperationException(
                    "X-App-Id and X-App-Token are required for Loyalty v2 HTTP calls.");
            }
        }

        private static string BuildUrl(string path, IDictionary<string, object> query)
        {
            string host = TestConfiguration.Host ?? "https://api.voucherify.io";
            host = host.Trim().TrimEnd('/');
            if (host.EndsWith("/v1", StringComparison.OrdinalIgnoreCase))
            {
                host = host.Substring(0, host.Length - 3).TrimEnd('/');
            }

            string normalizedPath = path.StartsWith("/") ? path : "/" + path;
            string url = host + normalizedPath;

            if (query == null || query.Count == 0)
            {
                return url;
            }

            var parts = new List<string>();
            foreach (KeyValuePair<string, object> entry in query)
            {
                if (entry.Value == null)
                {
                    continue;
                }

                parts.Add(
                    $"{Uri.EscapeDataString(entry.Key)}={Uri.EscapeDataString(Convert.ToString(entry.Value))}");
            }

            return parts.Count == 0 ? url : url + "?" + string.Join("&", parts);
        }

        private static JsonElement? ParseBody(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return null;
            }

            try
            {
                using var document = JsonDocument.Parse(text);
                return document.RootElement.Clone();
            }
            catch (JsonException)
            {
                return JsonDocument.Parse(JsonSerializer.Serialize(text)).RootElement.Clone();
            }
        }
    }
}
