using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;
using Xunit.Extensions.Ordering;

namespace Voucherify.Test
{
    [TestCaseOrderer("Xunit.Extensions.Ordering.TestCaseOrderer", "Xunit.Extensions.Ordering")]
    [Collection("RequiresManagementCredentials")]
    public class ManagementApiTests
    {
        private readonly ITestOutputHelper _output;
        private readonly ManagementApi _managementApi;
        private static string _projectId = TestConfiguration.GetTestProjectId();

        public ManagementApiTests(ITestOutputHelper output)
        {
            _output = output;

            // Skip tests if credentials are not provided
            if (!TestConfiguration.HasManagementCredentials)
            {
                _output.WriteLine("Management credentials not provided. Skipping tests.");
                return;
            }

            var configuration = TestConfiguration.GetManagementConfiguration();
            _managementApi = new ManagementApi(configuration);
        }

        [Fact, Order(1)]
        public void Test_ManagementConfiguration()
        {
            // Arrange
            var config = TestConfiguration.GetManagementConfiguration();

            // Assert
            config.Should().NotBeNull();
            config.BasePath.Should().NotBeNullOrEmpty();
        }

        [SkippableFact, Order(2)]
        public async Task Test_Query_Projects()
        {
            Skip.If(!TestConfiguration.HasManagementCredentials, "Management credentials not provided");

            // Query all projects
            var projectsResponse = await _managementApi.ListProjectsAsync();

            // Assert projects response
            projectsResponse.Should().NotBeNull();
            projectsResponse.Data.Should().NotBeNull();
            projectsResponse.Total.Should().BeGreaterThan(0);

            // Check at least one project
            var project = projectsResponse.Data[0];
            project.Should().NotBeNull();
            project.Id.Should().NotBeNullOrEmpty();
            project.Name.Should().NotBeNullOrEmpty();

            _output.WriteLine($"Found {projectsResponse.Total} projects");
        }

        [SkippableFact, Order(3)]
        public async Task Test_List_Metadata_Schemas()
        {
            Skip.If(!TestConfiguration.HasManagementCredentials, "Management credentials not provided");
            Skip.If(_projectId == null, "projectId is not provided");

            // Get list of metadata schemas
            var schemas = await _managementApi.ListMetadataSchemas1Async(_projectId);

            // Assert schemas response
            schemas.Should().NotBeNull();
            schemas.Data.Should().NotBeNull();

            _output.WriteLine($"Found {schemas.Total} metadata schemas");

            if (schemas.Total > 0)
            {
                var schema = schemas.Data[0];
                schema.RelatedObject.Should().NotBeNullOrEmpty();
            }
        }

        [SkippableFact, Order(4)]
        public async Task Test_Update_Metadata_Schema()
        {
            Skip.If(!TestConfiguration.HasManagementCredentials, "Management credentials not provided");
            Skip.If(_projectId == null, "projectId is not provided");

            // Get list of existing schemas
            var schemas = await _managementApi.ListMetadataSchemas1Async(_projectId);

            // Try to find or create a schema to update
            string schemaName = "test-dotnet-sdk";

            if (schemas.Total == 0 || !schemas.Data.Exists(s => s.RelatedObject == schemaName))
            {
                _output.WriteLine($"No existing schema named '{schemaName}' found. Creating a new one.");

                // Create a new schema through Management API
                var createRequest = new ManagementProjectsMetadataSchemasCreateRequestBody
                {
                    RelatedObject = schemaName,
                    AllowDefinedOnly = false,
                    Properties = new Dictionary<string, ManagementProjectsMetadataSchemaDefinition>
                    {
                        ["Test"] = new ManagementProjectsMetadataSchemaDefinition
                        {
                            Type = ManagementProjectsMetadataSchemaDefinition.TypeEnum.String,
                            Array = false,
                            Optional = true,
                            ObjectType = null,
                            Eq = new List<object>
                            {
                                "Test-01",
                                "Test-02",
                                "Test-03",
                                "Test-04"
                            }
                        }
                    }
                };

                await _managementApi.CreateMetadataSchemaAsync(_projectId, createRequest);

                // Wait a moment for the schema to be available
                await Task.Delay(2000);
                schemas = await _managementApi.ListMetadataSchemas1Async(_projectId);
            }

            var existingSchema = schemas.Data.Find(s => s.RelatedObject == schemaName);
            if (existingSchema == null)
            {
                _output.WriteLine("Test failed");
                throw new System.Exception("Schema not found");
            }

            existingSchema.Should().NotBeNull();

            var newSchemaName = TestHelpers.GenerateUniqueName("Schema");
            // Prepare update - add a new property or modify existing one
            var properties = new Dictionary<string, ManagementProjectsMetadataSchemaDefinition>
                 {
                     [newSchemaName] = new ManagementProjectsMetadataSchemaDefinition
                     {
                         Type = ManagementProjectsMetadataSchemaDefinition.TypeEnum.String,
                         Array = false,
                         Optional = true,
                         ObjectType = null,
                         Eq = new List<object>
                         {
                             "Test-01",
                             "Test-02",
                             "Test-03",
                             "Test-04"
                         }
                     }
                 };

            var updateRequest = new ManagementProjectsMetadataSchemasUpdateRequestBody
            {
                AllowDefinedOnly = existingSchema.AllowDefinedOnly,
                Properties = properties
            };

            var updateResult = await _managementApi.UpdateMetadataSchemaAsync(_projectId, existingSchema.Id, updateRequest);

            // Assert update result
            updateResult.Should().NotBeNull();

            _output.WriteLine($"Successfully updated schema: {schemaName}");
        }
    }
}
