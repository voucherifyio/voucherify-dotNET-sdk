using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Voucherify.Model;
using Voucherify.Test;
using FluentAssertions;

namespace Voucherify.Test.Tests
{
    public class RedemptionsTests
    {
        private readonly StackableFlow _stackableFlow;
        private readonly PublicationFlow _publicationFlow;

        public RedemptionsTests()
        {
            _stackableFlow = new StackableFlow();
            _publicationFlow = new PublicationFlow();
        }

        [Fact]
        public async Task ValidateStackedDiscounts()
        {
            var resultTemp = await _publicationFlow.createAndPublishVoucherForCustomer(
                TestHelper.GenerateUniqueName("Campaign"),
                2
            );

            var voucherIds = new List<string> { resultTemp.Vouchers[0].Id, resultTemp.Vouchers[1].Id };
            var productId = "test-product";
            var customer = new Customer
            {
                Id = "test-customer",
                Name = "Test Customer"
            };
            var amount = 20000;

            var result = await _stackableFlow.ValidateStackedDiscounts(voucherIds, productId, customer, amount);

            result.Should().NotBeNull();
            result.Redeemables.Should().NotBeNull();
            result.Redeemables.Should().HaveCount(voucherIds.Count);
        }

        [Fact]
        public async Task RedeemStackedDiscounts_ThenListRedemptions_ByVoucherCodes()
        {
            var resultTemp = await _publicationFlow.createAndPublishVoucherForCustomer(
                TestHelper.GenerateUniqueName("Campaign"),
                2
            );

            var voucherIds = new List<string> { resultTemp.Vouchers[0].Id, resultTemp.Vouchers[1].Id };
            voucherIds.Should().AllSatisfy(id => id.Should().NotBeNullOrWhiteSpace());

            var voucherCodes = new List<string> { resultTemp.Vouchers[0].Code, resultTemp.Vouchers[1].Code };
            voucherCodes.Should().AllSatisfy(code => code.Should().NotBeNullOrWhiteSpace());

            var redeemResult = await _stackableFlow.RedeemStackedDiscounts(voucherIds);

            redeemResult.Should().NotBeNull();
            redeemResult.Redemptions.Should().NotBeNull();
            redeemResult.Redemptions.Should().HaveCount(voucherIds.Count);

            var listResult = await _stackableFlow.ListRedemptions(voucherCodes);

            listResult.Should().NotBeNull();
            listResult.Redemptions.Should().NotBeNull();
            listResult.Redemptions.Should().HaveCountLessThanOrEqualTo(10);
            listResult.Redemptions.Should().HaveCountGreaterThanOrEqualTo(1);

            listResult.Redemptions.Should().Contain(r => r.Voucher != null && voucherCodes.Contains(r.Voucher.Code));
        }
    }
}
