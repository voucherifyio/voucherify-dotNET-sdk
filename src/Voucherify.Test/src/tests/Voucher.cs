using System.Threading.Tasks;
using FluentAssertions;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;
using Xunit;
using Xunit.Abstractions;
using Xunit.Extensions.Ordering;

namespace Voucherify.Test
{
    [Collection("RequiresClientCredentials")]
    public class VoucherTest
    {
        private readonly ITestOutputHelper _output;
        private readonly VoucherFlow _voucherFlow;
        private readonly CampaignFlow _campaignFlow;
        private readonly CustomerFlow _customerFlow;
        private readonly int _delayMilliseconds = 2000;

        public VoucherTest(ITestOutputHelper output)
        {
            _output = output;
            _voucherFlow = new VoucherFlow();
            _campaignFlow = new CampaignFlow();
            _customerFlow = new CustomerFlow();
        }

        [SkippableFact]
        public async Task TestVoucherEnableDisable()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var campaignName = TestHelper.GenerateUniqueName("Campaign");
            var campaign = await _campaignFlow.createDiscountCampaign(campaignName, 1);

            await Task.Delay(_delayMilliseconds);

            var vouchers = await _campaignFlow.getCampaignVouchers(campaign.Id);
            var voucher = vouchers.Vouchers[0];

            voucher.Should().NotBeNull();
            voucher.Code.Should().Be(voucher.Code);
            voucher.Active.Should().BeTrue();

            var disableResponse = await _voucherFlow.DisableVoucher(voucher.Code);
            disableResponse.Should().NotBeNull();
            disableResponse.Code.Should().Be(voucher.Code);
            disableResponse.Active.Should().BeFalse();

            await Task.Delay(_delayMilliseconds);

            var enableResponse = await _voucherFlow.EnableVoucher(voucher.Code);
            enableResponse.Should().NotBeNull();
            enableResponse.Code.Should().Be(voucher.Code);
            enableResponse.Active.Should().BeTrue();
        }

        [SkippableFact]
        public async Task TestUpdateLoyaltyCardBalance()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var initialAmount = 1000;
            var campaignName = TestHelper.GenerateUniqueName("Campaign");
            var campaign = await _campaignFlow.createLoyaltyCampaign(campaignName, 1000, 1);

            await Task.Delay(_delayMilliseconds);

            var vouchers = await _campaignFlow.getCampaignVouchers(campaign.Id);
            var firstVoucher = vouchers.Vouchers[0];

            var customerResponse = await _customerFlow.createCustomer(
                TestHelper.GenerateUniqueName("CustomerName"),
                TestHelper.GenerateUniqueEmail()
            );
            await _campaignFlow.createPublication(new Customer(customerResponse.Id), firstVoucher.Code);

            var sourceId = TestHelper.GenerateUniqueName("Source");
            var amount = 10000;
            var reason = "Regular customer";

            var response = await _voucherFlow.UpdateLoyaltyCardBalance(
                firstVoucher.Code,
                sourceId,
                amount,
                reason
            );

            response.Should().NotBeNull();
            response.Balance.Should().Be(amount + initialAmount);
        }
    }
} 