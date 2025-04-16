using System;
using System.IO;
using Voucherify.Client;
using Xunit;

namespace Voucherify.Test
{
    public class TestConfiguration
    {
        private static bool _initialized = false;

        public static string Host { get; private set; } = "https://api.voucherify.io";
        public static string AppId { get; private set; } = "";
        public static string AppToken { get; private set; } = "";
        public static string ManagementId { get; private set; } = "";
        public static string ManagementToken { get; private set; } = "";
        public static string ProjectId { get; private set; } = "";

        private static string OAuthAccessToken = "";

        static TestConfiguration()
        {
            Initialize();
        }

        public static void Initialize()
        {
            if (_initialized) return;

            try
            {
                // Try to load from .env file in the project directory
                string envPath = Path.Combine(Directory.GetCurrentDirectory(), "env");
                if (File.Exists(envPath))
                {
                    // Load environment variables from file
                    foreach (var line in File.ReadAllLines(envPath))
                    {
                        if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#")) continue;

                        var parts = line.Split(new[] { '=' }, 2);
                        if (parts.Length != 2) continue;

                        Environment.SetEnvironmentVariable(parts[0], parts[1]);
                    }
                }
                else
                {
                    // Try to find env file in parent directories (useful for development)
                    string currentDir = Directory.GetCurrentDirectory();
                    while (!File.Exists(Path.Combine(currentDir, "env")) && Directory.GetParent(currentDir) != null)
                    {
                        currentDir = Directory.GetParent(currentDir).FullName;
                    }

                    if (File.Exists(Path.Combine(currentDir, "env")))
                    {
                        // Load environment variables from file
                        foreach (var line in File.ReadAllLines(Path.Combine(currentDir, "env")))
                        {
                            if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#")) continue;

                            var parts = line.Split(new[] { '=' }, 2);
                            if (parts.Length != 2) continue;

                            Environment.SetEnvironmentVariable(parts[0], parts[1]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Warning: env file not found. Using default or environment values.");
                    }
                }

                Host = Environment.GetEnvironmentVariable("VOUCHERIFY_HOST") ?? Host;
                AppId = Environment.GetEnvironmentVariable("X_APP_ID") ?? AppId;
                AppToken = Environment.GetEnvironmentVariable("X_APP_TOKEN") ?? AppToken;
                ManagementId = Environment.GetEnvironmentVariable("X_MANAGEMENT_ID") ?? ManagementId;
                ManagementToken = Environment.GetEnvironmentVariable("X_MANAGEMENT_TOKEN") ?? ManagementToken;
                ProjectId = Environment.GetEnvironmentVariable("PROJECT_ID") ?? ProjectId;
                _initialized = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading configuration: {ex.Message}");
                throw;
            }
        }

        public static string GetTestProjectId()
        {
            return ProjectId;
        }

        public static Configuration GetClientConfiguration()
        {
            var config = new Configuration
            {
                BasePath = Host
            };

            // Set API keys via headers
            config.DefaultHeaders.Add("X-App-Id", AppId);
            config.DefaultHeaders.Add("X-App-Token", AppToken);

            return config;
        }

        public static Configuration GetManagementConfiguration()
        {
            var config = new Configuration
            {
                BasePath = Host
            };

            // Set API keys via headers
            config.DefaultHeaders.Add("X-Management-Id", ManagementId);
            config.DefaultHeaders.Add("X-Management-Token", ManagementToken);

            return config;
        }

        public static Configuration GetOAuthConfiguration(string accessToken)
        {
            OAuthAccessToken = accessToken;
            var config = new Configuration
            {
                BasePath = Host,
                AccessToken = accessToken
            };

            return config;
        }

        public static bool HasClientCredentials => !string.IsNullOrEmpty(AppId) && !string.IsNullOrEmpty(AppToken);
        public static bool HasManagementCredentials => !string.IsNullOrEmpty(ManagementId) && !string.IsNullOrEmpty(ManagementToken);
        public static bool HasOAuthCredentials => !string.IsNullOrEmpty(OAuthAccessToken);
    }

    [CollectionDefinition("RequiresClientCredentials")]
    public class RequiresClientCredentials : ICollectionFixture<TestConfiguration>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }

    [CollectionDefinition("RequiresManagementCredentials")]
    public class RequiresManagementCredentials : ICollectionFixture<TestConfiguration>
    {
    }

    [CollectionDefinition("RequiresOAuthCredentials")]
    public class RequiresOAuthCredentials : ICollectionFixture<TestConfiguration>
    {
    }
}
