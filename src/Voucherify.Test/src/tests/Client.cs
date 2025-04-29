using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;
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
    [Collection("RequiresClientCredentials")]
    public class ClientTest
    {
        private readonly ITestOutputHelper _output;
        private readonly CampaignsApi _campaignsApi;
        private readonly VouchersApi _vouchersApi;
        private readonly AsyncActionsApi _asyncActionsApi;
        private readonly QualificationsApi _qualificationsApi;
        private readonly ValidationsApi _validationsApi;
        private readonly RedemptionsApi _redemptionsApi;
        private readonly PublicationsApi _publicationsApi;
        private readonly CampaignFlow _campaignFlow;

        private static CustomersCreateResponseBody _customer;
        private static CampaignsCreateResponseBody _campaign;
        private static VoucherWithCategories _voucher;

        private int _delayMilliseconds = 2000;
        private int _voucherDiscountAmount = 15;

        public ClientTest(ITestOutputHelper output)
        {
            _output = output;

            // Skip tests if credentials are not provided
            if (!TestConfiguration.HasClientCredentials)
            {
                _output.WriteLine("Client credentials not provided. Skipping tests.");
                return;
            }

            var configuration = TestConfiguration.GetClientConfiguration();
            _campaignsApi = new CampaignsApi(configuration);
            _vouchersApi = new VouchersApi(configuration);
            _qualificationsApi = new QualificationsApi(configuration);
            _validationsApi = new ValidationsApi(configuration);
            _redemptionsApi = new RedemptionsApi(configuration);
            _asyncActionsApi = new AsyncActionsApi(configuration);
            _publicationsApi = new PublicationsApi(configuration);

            _campaignFlow = new CampaignFlow();
        }

        [Fact, Order(1)]
        public void Test_ClientConfiguration()
        {
            // Arrange
            var config = TestConfiguration.GetClientConfiguration();

            // Assert
            config.Should().NotBeNull();
            config.BasePath.Should().NotBeNullOrEmpty();
        }

        [SkippableFact, Order(2)]
        public async Task Test_Import_CSV_With_Vouchers()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var campaignName = TestHelper.GenerateUniqueName("Campaign");
            var _campaign = await _campaignFlow.createDiscountCampaign(campaignName, 0);

            string csvPath = Path.Combine(Directory.GetCurrentDirectory(), "standalone_discount_vouchers_template_voucherify_client.csv");

            // Ensure CSV file exists
            var fileInfo = new FileInfo(csvPath);
            fileInfo.Exists.Should().BeTrue();

            // Read CSV using Stream
            using var fileStream = File.OpenRead(csvPath);
            var importResult = await _campaignsApi.ImportVouchersToCampaignUsingCsvAsync(_campaign.Id, fileStream);

            // Assert import was successful
            importResult.Should().NotBeNull();
            importResult.AsyncActionId.Should().NotBeNullOrEmpty();

            _output.WriteLine($"Import initiated with async action ID: {importResult.AsyncActionId}");

            // Ensure async action was completed
            int maxAttempts = 10;
            int attemptCount = 0;
            string asyncActionId = importResult.AsyncActionId;

            while (true)
            {
                await Task.Delay(_delayMilliseconds);
                attemptCount++;

                var action = await _asyncActionsApi.GetAsyncActionAsync(asyncActionId);

                if (action.OperationStatus == AsyncActionGetResponseBody.OperationStatusEnum.SUCCESS)
                {
                    _output.WriteLine($"Async action {asyncActionId} completed successfully");
                    var listVouchersResult = await _vouchersApi.ListVouchersAsync(
                        campaignId: _campaign.Id
                    );
                    _voucher = listVouchersResult.Vouchers[0];
                    _voucher.Should().NotBeNull();

                    // Assert voucher properties
                    _voucher.Should().NotBeNull();
                    _voucher.Campaign.Should().Be(_campaign.Name);

                    break;
                }

                if (action.OperationStatus == AsyncActionGetResponseBody.OperationStatusEnum.FAILED)
                {
                    _output.WriteLine($"Async action {asyncActionId} failed");
                    throw new Exception($"Async action {asyncActionId} failed");
                }

                _output.WriteLine($"Async action is still in progress. Status: {action.Status}, attempt: {attemptCount}/{maxAttempts}");

                if (attemptCount >= maxAttempts)
                {
                    _output.WriteLine($"Async action {asyncActionId} timed out after {maxAttempts} attempts");
                    throw new Exception($"Async action did not complete after {maxAttempts} attempts");
                }
            }
        }


        [SkippableFact, Order(5)]
        public async Task Test_Qualifications()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");
            Skip.If(_customer == null, "Customer not created");
            Skip.If(_voucher == null, "Voucher not created");

            // Check eligibility
            var order = new Order(
                amount: 100
            );

            var qualificationsRequest = new QualificationsCheckEligibilityRequestBody(
                customer: new Customer
                {
                    Id = _customer.Id
                },
                order: order,
                scenario: QualificationsCheckEligibilityRequestBody.ScenarioEnum.CUSTOMERWALLET,
                options: new QualificationsOption(
                    filters: new QualificationsOptionFilters(
                        resourceType: new QualificationsOptionFiltersResourceType(
                            conditions: new QualificationsOptionFiltersResourceTypeConditions(
                                varIs: new List<ResourceTypes> { ResourceTypes.Voucher }
                            )
                        )
                    )
                )
            );

            var qualificationsResult = await _qualificationsApi.CheckEligibilityAsync(qualificationsRequest);

            // Assert qualifications result
            qualificationsResult.Should().NotBeNull();
            qualificationsResult.Order.Should().NotBeNull();


            _output.WriteLine($"Qualifications result received with {qualificationsResult.Redeemables.Total} redeemables");

        }

        [SkippableFact, Order(6)]
        public async Task Test_Validation_And_Redemption()
        {
            Skip.If(_customer == null, "Customer not created");
            Skip.If(_campaign == null, "Campaign not created");
            Skip.If(_voucher == null, "Voucher not created");

            // Validate the voucher
            var order = new Order(
                amount: 100
            );
            var sessionKey = TestHelper.GenerateUniqueName("Session");

            var validateRequest = new ValidationsValidateRequestBody(
                redeemables: new List<ValidationsValidateRequestBodyRedeemablesItem>
                {
                    new ValidationsValidateRequestBodyRedeemablesItem(
                        id: _voucher.Code,
                        varObject: ValidationsValidateRequestBodyRedeemablesItem.ObjectEnum.Voucher
                    )
                },
                order: order,
                customer: new Customer(
                    id: _customer.Id
                ),
                session: new Session(
                    key: sessionKey,
                    type: Session.TypeEnum.LOCK,
                    ttl: 1,
                    ttlUnit: Session.TtlUnitEnum.DAYS
                )
            );

            var validationResult = await _validationsApi.ValidateStackedDiscountsAsync(validateRequest);

            // Assert validation result
            validationResult.Should().NotBeNull();
            validationResult.Valid.Should().BeTrue();
            validationResult.Redeemables.Should().NotBeNull();
            validationResult.Order.Should().NotBeNull();
            validationResult.Order.Amount.Should().Be(order.Amount);
            validationResult.Order.DiscountAmount.Should().Be(_voucherDiscountAmount);

            _output.WriteLine($"Validation successful for voucher: {_voucher.Code}");

            // Redeem the voucher
            var redeemRequest = new RedemptionsRedeemRequestBody(
                redeemables: new List<RedemptionsRedeemRequestBodyRedeemablesItem>
                {
                    new RedemptionsRedeemRequestBodyRedeemablesItem(
                        id: _voucher.Code,
                        varObject: RedemptionsRedeemRequestBodyRedeemablesItem.ObjectEnum.Voucher
                    )
                },
                order: order,
                customer: new Customer(
                    id: _customer.Id
                )
            );

            var redemptionResult = await _redemptionsApi.RedeemStackedDiscountsAsync(redeemRequest);

            // Assert redemption result
            redemptionResult.Should().NotBeNull();
            redemptionResult.Redemptions.Should().NotBeNull();
            redemptionResult.Order.Should().NotBeNull();
            redemptionResult.Order.Amount.Should().Be(order.Amount);
            redemptionResult.Order.DiscountAmount.Should().Be(_voucherDiscountAmount);

            _output.WriteLine($"Redemption successful for voucher: {_voucher.Code}");
        }

        [Fact, Order(0)]
        public void Test_CsvFile_Exists()
        {
            // Generate a random code for the voucher
            string randomCode = TestHelper.GenerateUniqueName("VoucherCode");

            // Define the CSV content with the random code
            string csvContent =
                "Code,Voucher Type,Active,Start Date,Expiration Date,Discount Type,Value,Category,Redemption Limit,Additional Info,Region\n" +
                $"{randomCode},DISCOUNT_VOUCHER,TRUE,,,AMOUNT,{_voucherDiscountAmount},New,,Planned release in Fall 2022,Europe";

            // Determine the file path
            string csvPath = Path.Combine(Directory.GetCurrentDirectory(), "standalone_discount_vouchers_template_voucherify_client.csv");

            // Write the content to the file
            File.WriteAllText(csvPath, csvContent);

            // Verify the file exists
            var fileInfo = new FileInfo(csvPath);
            fileInfo.Exists.Should().BeTrue();

            // Output the file path for reference
            _output.WriteLine($"CSV file created: {csvPath}");
            _output.WriteLine($"With random voucher code: {randomCode}");
            _output.WriteLine($"CSV file exists: {csvPath}, size: {fileInfo.Length} bytes");
        }
    }
}
