using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;
using Xunit;
using Xunit.Abstractions;

namespace Voucherify.Test
{
    [Collection("RequiresClientCredentials")]
    public class ValidationsTest
    {
        private readonly StackableFlow _stackableFlow;
        private readonly PublicationFlow _publicationFlow;

        public ValidationsTest()
        {
            _stackableFlow = new StackableFlow();
            _publicationFlow = new PublicationFlow();
        }

        [SkippableFact]
        public async Task ValidateStackedDiscountsAllApplicable()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var publicationResult = await _publicationFlow.createAndPublishVoucherForCustomer(
                TestHelper.GenerateUniqueName("Campaign"),
                1
            );

            var voucherIds = new List<string> { publicationResult.Vouchers[0].Id };
            var productId = "test-product";
            var customer = new Customer
            {
                Id = publicationResult.Customer.Id,
            };

            var validationResult = await _stackableFlow.ValidateStackedDiscounts(
                voucherIds,
                productId,
                customer,
                20000
            );

            validationResult.Should().NotBeNull();
            validationResult.TrackingId.Should().NotBeNull();
            validationResult.Redeemables.Should().HaveCount(voucherIds.Count);
            validationResult.Redeemables.Should().BeOfType<List<ValidationsValidateResponseBodyRedeemablesItem>>();

            var order = validationResult.Order;
            order.Should().NotBeNull();
            order.Amount.Should().Be(20000);
            order.TotalAmount.Should().Be(20000 - 15);

            var redeemable = validationResult.Redeemables[0];
            redeemable.Should().NotBeNull();
            redeemable.Status.Should().Be(ValidationsValidateResponseBodyRedeemablesItem.StatusEnum.APPLICABLE);
            redeemable.Id.Should().NotBeNull();
            redeemable.Object.Should().Be(ValidationsValidateResponseBodyRedeemablesItem.ObjectEnum.Voucher);
            redeemable.Order.Should().BeOfType<ValidationsValidateResponseBodyRedeemablesItemOrder>();
            redeemable.ApplicableTo.Should().BeOfType<ApplicableToResultList>();
            redeemable.InapplicableTo.Should().BeOfType<InapplicableToResultList>();
            redeemable.Result.Should().BeOfType<ValidationsValidateResponseBodyRedeemablesItemResult>();

            var discount = redeemable.Result.Discount;
            discount.Type.Should().Be(ValidationsValidateResponseBodyRedeemablesItemResultDiscount.TypeEnum.AMOUNT);
            discount.AmountOff.Should().Be(15);
        }

        [SkippableFact]
        public async Task ValidateStackedDiscountsWithInapplicable()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var publicationResult = await _publicationFlow.createAndPublishVoucherForCustomer(
                TestHelper.GenerateUniqueName("Campaign"),
                1
            );

            var voucherIds = new List<string> { publicationResult.Vouchers[0].Id, TestHelper.GenerateUniqueName("VoucherId") };
            var productId = "test-product";
            var customer = new Customer
            {
                Id = TestHelper.GenerateUniqueName("CustomerId"),
            };

            var validationResult = await _stackableFlow.ValidateStackedDiscounts(
                voucherIds,
                productId,
                customer,
                1000
            );

            validationResult.Should().NotBeNull();
            validationResult.Valid.Should().BeFalse();

            validationResult.Redeemables.Should().NotBeNull();
            validationResult.Redeemables.Should().BeOfType<List<ValidationsValidateResponseBodyRedeemablesItem>>();

            var inapplicableRedeemables = validationResult.InapplicableRedeemables[0];
            inapplicableRedeemables.Should().NotBeNull();
            inapplicableRedeemables.Should().BeOfType<ValidationsRedeemableInapplicable>();
            inapplicableRedeemables.Status.Should().Be(ValidationsRedeemableInapplicable.StatusEnum.INAPPLICABLE);
            inapplicableRedeemables.Id.Should().NotBeNull();
            inapplicableRedeemables.Object.Should().Be(ValidationsRedeemableInapplicable.ObjectEnum.Voucher);
            inapplicableRedeemables.Result.Should().NotBeNull();
            inapplicableRedeemables.Result.Should().BeOfType<ValidationsRedeemableInapplicableResult>();
            inapplicableRedeemables.Result.Error.Should().NotBeNull();
            inapplicableRedeemables.Result.Error.Should().BeOfType<Error>();
        }

        [SkippableFact]
        public async Task ValidateCustomerResponseFailed()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var voucherIds = new List<string> { TestHelper.GenerateUniqueName("VoucherId") };
            var productId = "test-product";


            var validationResult = await _stackableFlow.ValidateStackedDiscounts(
                voucherIds,
                productId,
                null,
                1000
            );

            validationResult.Should().NotBeNull();
            validationResult.Valid.Should().BeFalse();
            validationResult.Redeemables.Should().NotBeNull();
            validationResult.Redeemables.Should().BeOfType<List<ValidationsValidateResponseBodyRedeemablesItem>>();
            validationResult.InapplicableRedeemables.Should().NotBeNull();
            validationResult.InapplicableRedeemables.Should().BeOfType<List<ValidationsRedeemableInapplicable>>();
            validationResult.Redeemables.Should().HaveCount(validationResult.InapplicableRedeemables.Count);
        }

        //TODO: add test for validation rules
    }
} 