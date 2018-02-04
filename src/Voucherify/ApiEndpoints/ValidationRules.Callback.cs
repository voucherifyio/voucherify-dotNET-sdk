#if !APIASYNC
using System;
using Voucherify.Core.Communication;

namespace Voucherify.ApiEndpoints
{
    public class ValidationRules : EndpointBase
    {
        public ValidationRules(Api api) : base(api)
        {
        }

        public void Get(string validationRuleId, Action<ApiResponse<DataModel.ValidationRule>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}", Uri.EscapeDataString(validationRuleId)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void Create(DataModel.Contexts.ValidationRuleCreate validationRule, Action<ApiResponse<DataModel.ValidationRule>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/validation-rules/");
            this.client.DoPostRequest(uriBuilder.Uri, validationRule, callback);
        }

        public void Update(string validationRuleId, DataModel.Contexts.ValidationRuleUpdate validationRule, Action<ApiResponse<DataModel.ValidationRule>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}", Uri.EscapeDataString(validationRuleId)));
            this.client.DoPutRequest(uriBuilder.Uri, validationRule, callback);
        }

        public void Delete(string validationRuleId, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}", Uri.EscapeDataString(validationRuleId)));
            this.client.DoDeleteRequest(uriBuilder.Uri, callback);
        }
    }
}
#endif