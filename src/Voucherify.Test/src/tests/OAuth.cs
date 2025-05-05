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
    [Collection("RequiresOAuthCredentials")]
    public class OAuthTest
    {
        private readonly ITestOutputHelper _output;

        private readonly OAuthApi _oauthApi;
        private static CampaignsApi _campaignsApi;
        private static CustomersApi _customersApi;
        private static VouchersApi _vouchersApi;
        private static AsyncActionsApi _asyncActionsApi;
        private static QualificationsApi _qualificationsApi;
        private static ValidationsApi _validationsApi;
        private static RedemptionsApi _redemptionsApi;
        private static PublicationsApi _publicationsApi;

        private static CustomersCreateResponseBody _customer;
        private static CampaignsCreateResponseBody _campaign;
        private static VoucherWithCategories _voucher;
        private int _delayMilliseconds = 2000;
        private int _voucherDiscountAmount = 15;

        public OAuthTest(ITestOutputHelper output)
        {
            _output = output;
            _oauthApi = new OAuthApi(TestConfiguration.GetClientConfiguration());
        }


        [SkippableFact, Order(1)]
        public async Task Test_Create_OAuth_Token()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            // Generate an OAuth token
            var tokenResponse = await _oauthApi.GenerateOauthTokenAsync(
                "client_credentials",
                "api");

            // Assert token response
            tokenResponse.Should().NotBeNull();
            tokenResponse.AccessToken.Should().NotBeNullOrEmpty();
            //FIXME tokenResponse.TokenType.Should().Be(OAuthTokenGenerateResponseBody.TokenTypeEnum.Bearer);
            tokenResponse.ExpiresIn.Should().BeGreaterThan(0);
            tokenResponse.Scope.Should().Contain("api");

            _output.WriteLine($"Generated OAuth token with scope: {tokenResponse.Scope}");

            // Create configuration with the OAuth token
            var oauthConfig = TestConfiguration.GetOAuthConfiguration(tokenResponse.AccessToken);

            // Initialize APIs with the OAuth token
            _campaignsApi = new CampaignsApi(oauthConfig);
            _customersApi = new CustomersApi(oauthConfig);
            _vouchersApi = new VouchersApi(oauthConfig);
            _qualificationsApi = new QualificationsApi(oauthConfig);
            _validationsApi = new ValidationsApi(oauthConfig);
            _redemptionsApi = new RedemptionsApi(oauthConfig);
            _asyncActionsApi = new AsyncActionsApi(oauthConfig);
            _publicationsApi = new PublicationsApi(oauthConfig);
        }

        [SkippableFact, Order(2)]
        public async Task Test_Create_Campaign_And_Customer()
        {
            Skip.If(!TestConfiguration.HasOAuthCredentials, "Client credentials not provided");

            // Create a campaign
            var campaignName = TestHelper.GenerateUniqueName("TestCampaign");
            var campaignsCreateRequestBody = new CampaignsCreateRequestBody(
                name: campaignName,
                type: CampaignsCreateRequestBody.TypeEnum.AUTOUPDATE,
                voucher: new CampaignsCreateRequestBodyVoucher(
                    type: CampaignsCreateRequestBodyVoucher.TypeEnum.DISCOUNTVOUCHER,
                    discount: new Discount(
                        type: Discount.TypeEnum.AMOUNT,
                        amountOff: _voucherDiscountAmount
                    ),
                    redemption: new CampaignsCreateRequestBodyVoucherRedemption(
                        quantity: 10
                    )
                ),
                vouchersCount: 0
            );

            _campaign = await _campaignsApi.CreateCampaignAsync(campaignsCreateRequestBody);

            // Assert campaign created successfully
            _campaign.Should().NotBeNull();
            _campaign.Name.Should().Be(campaignName);
            _campaign.Id.Should().NotBeNullOrEmpty();

            _output.WriteLine($"Created campaign: {_campaign.Name} with ID: {_campaign.Id}");

            // Create a customer
            var customerEmail = TestHelper.GenerateUniqueEmail();
            var customersCreateRequestBody = new CustomersCreateRequestBody(
                name: "Test Customer",
                email: customerEmail,
                description: "Test customer for .NET SDK tests"
            );

            _customer = await _customersApi.CreateCustomerAsync(customersCreateRequestBody);


            // Assert customer created successfully
            _customer.Should().NotBeNull();
            _customer.Email.Should().Be(customerEmail);
            _customer.Id.Should().NotBeNullOrEmpty();

            _output.WriteLine($"Created customer: {_customer.Name} with ID: {_customer.Id}");
        }

        [SkippableFact, Order(3)]
        public async Task Test_Import_CSV_With_Vouchers()
        {
            Skip.If(!TestConfiguration.HasOAuthCredentials, "Client credentials not provided");
            Skip.If(_campaign == null, "Campaign is not created");

            string csvPath = Path.Combine(Directory.GetCurrentDirectory(), "standalone_discount_vouchers_template_voucherify_oauth.csv");

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

        [SkippableFact, Order(4)]
        public async Task Test_Retrieve_Voucher_From_Campaign_And_Publish_For_Customer()
        {
            Skip.If(!TestConfiguration.HasOAuthCredentials, "Client credentials not provided");
            Skip.If(_customer == null, "Customer not created");
            Skip.If(_campaign == null, "Campaign not created");
            Skip.If(_voucher == null, "Voucher not created");

            _output.WriteLine($"Retrieved voucher: {_voucher.Code} from campaign: {_voucher.Campaign}");

            var publicationsCreateRequestBody = new PublicationsCreateRequestBody
            {
                Customer = new Customer
                {
                    Id = _customer.Id
                },
                Voucher = _voucher.Code
            };

            var publication = await _publicationsApi.CreatePublicationAsync(true, publicationsCreateRequestBody);

            publication.Should().NotBeNull();
            publication.CustomerId.Should().Be(_customer.Id);
            publication.Voucher.Code.Should().Be(_voucher.Code);

            await Task.Delay(_delayMilliseconds);
        }


        [SkippableFact, Order(5)]
        public async Task Test_Qualifications()
        {
            Skip.If(!TestConfiguration.HasOAuthCredentials, "Client credentials not provided");
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
            string csvPath = Path.Combine(Directory.GetCurrentDirectory(), "standalone_discount_vouchers_template_voucherify_oauth.csv");

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
