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
    [Collection("RequiresClientCredentials")]
    public class CampaignTest
    {
        private readonly ITestOutputHelper _output;
        private readonly CampaignFlow _campaignFlow;
        private readonly CustomerFlow _customerFlow;
        private readonly PublicationFlow _publicationFlow;

        public CampaignTest(ITestOutputHelper output)
        {
            _output = output;
            _campaignFlow = new CampaignFlow();
            _customerFlow = new CustomerFlow();
            _publicationFlow = new PublicationFlow();
        }

        [SkippableFact]
        public async Task TestPublishCampaignVoucher()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var customerName = TestHelper.GenerateUniqueName("CustomerName");
            var customerEmail = TestHelper.GenerateUniqueEmail();
            var campaignName = TestHelper.GenerateUniqueName("Campaign");
            var vouchersCount = 3;

            var campaign = await _campaignFlow.createDiscountCampaign(campaignName, vouchersCount);

            campaign.Should().NotBeNull();
            campaign.Name.Should().Be(campaignName);
            campaign.Id.Should().NotBeNullOrEmpty();

            var vouchers = await _campaignFlow.waitForCampaignVouchers(campaign.Id, vouchersCount);
            vouchers.Vouchers.Should().NotBeNull();
            vouchers.Vouchers.Should().HaveCount(vouchersCount);

            var firstVoucher = vouchers.Vouchers[0];
            firstVoucher.Should().NotBeNull();
            firstVoucher.Code.Should().NotBeNullOrEmpty();

            var customerResponse = await _customerFlow.createCustomer(customerName, customerEmail);
            customerResponse.Should().NotBeNull();
            customerResponse.Id.Should().NotBeNullOrEmpty();
            customerResponse.Name.Should().Be(customerName);
            customerResponse.Email.Should().Be(customerEmail);

            var publication = await _publicationFlow.createPublication(customerResponse.Id, firstVoucher.Code);
            publication.Should().NotBeNull();
            publication.Id.Should().NotBeNullOrEmpty();
        }

        [SkippableFact]
        public async Task TestAddVouchersToCampaign()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var campaignName = TestHelper.GenerateUniqueName("Campaign");
            var createdCampaign = await _campaignFlow.createDiscountCampaign(campaignName, 0);

            createdCampaign.Should().NotBeNull();
            createdCampaign.Name.Should().Be(campaignName);

            var singleVoucher = await _campaignFlow.addVoucherToCampaign(createdCampaign.Id);
            singleVoucher.Should().NotBeNull();
            singleVoucher.Code.Should().NotBeNullOrEmpty();
            singleVoucher.CampaignId.Should().Be(createdCampaign.Id);

            var bundle = await _campaignFlow.createBundleOfVouchers(createdCampaign.Id, 5);
            bundle.Should().NotBeNull();
            bundle.AsyncActionId.Should().NotBeNullOrEmpty();

            await _campaignFlow.waitForAsyncAction(bundle.AsyncActionId);

            var campaignVouchers = await _campaignFlow.waitForCampaignVouchers(createdCampaign.Id, 6);

            _output.WriteLine("campaignVouchers: " + campaignVouchers);

            campaignVouchers.Should().NotBeNull();
            campaignVouchers.Vouchers.Should().NotBeNull();
            campaignVouchers.Vouchers.Should().HaveCount(6);
        }
    }
}