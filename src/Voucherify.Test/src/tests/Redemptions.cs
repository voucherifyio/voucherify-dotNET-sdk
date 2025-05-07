using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Voucherify.Model;
using Voucherify.Test;
using FluentAssertions;

namespace Voucherify.Test.Tests
{
    //TODO: Need a bit of work
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
        public async Task RedeemStackedDiscounts()
        {
            var resultTemp = await _publicationFlow.createAndPublishVoucherForCustomer(
                TestHelper.GenerateUniqueName("Campaign"),
                2
            );

            var voucherIds = new List<string> { resultTemp.Vouchers[0].Id, resultTemp.Vouchers[1].Id };

            var result = await _stackableFlow.RedeemStackedDiscounts(voucherIds);

            result.Should().NotBeNull();
            result.Redemptions.Should().NotBeNull();
            result.Redemptions.Should().HaveCount(voucherIds.Count);
        }

        [Fact]
        public async Task ListRedemptions()
        {
            var result = await _stackableFlow.ListRedemptions();

            result.Should().NotBeNull();
            result.Redemptions.Should().NotBeNull();
            result.Redemptions.Should().HaveCountLessThanOrEqualTo(10);
            result.Redemptions.Should().HaveCountGreaterThanOrEqualTo(1);
        }
    }
}