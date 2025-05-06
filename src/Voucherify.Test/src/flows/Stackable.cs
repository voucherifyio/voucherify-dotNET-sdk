using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Voucherify.Test
{
    public class StackableFlow
    {
        private readonly ValidationsApi _validationsApi;
        private readonly RedemptionsApi _redemptionsApi;

        public StackableFlow()
        {
            _validationsApi = new ValidationsApi(TestConfiguration.GetClientConfiguration());
            _redemptionsApi = new RedemptionsApi(TestConfiguration.GetClientConfiguration());
        }

        public async Task<ValidationsValidateResponseBody> ValidateStackedDiscounts(
            List<string> voucherIds,
            string productId,
            Customer customer,
            int amount)
        {
            var redeemables = new List<ValidationsValidateRequestBodyRedeemablesItem>();
            foreach (var voucherId in voucherIds)
            {
                var validationsValidateRequestBodyRedeemablesItems = new List<ValidationsValidateRequestBodyRedeemablesItem>
                    {
                        new ValidationsValidateRequestBodyRedeemablesItem
                        {
                            Object = ValidationsValidateRequestBodyRedeemablesItem.ObjectEnum.Voucher,
                            Id = voucherId
                        }
                    };

                redeemables.AddRange(validationsValidateRequestBodyRedeemablesItems);
            }

            var requestBody = new ValidationsValidateRequestBody
            {
                Redeemables = redeemables,
                Order = new Order
                {
                    Items = new List<OrderItem>
                    {
                        new OrderItem
                        {
                            RelatedObject = OrderItem.RelatedObjectEnum.Product,
                            Quantity = 1,
                            DiscountQuantity = 1,
                            Amount = amount,
                            Price = amount,
                            ProductId = productId,
                            Product = new OrderItemProduct
                            {
                                Id = productId
                            }
                        }
                    },
                    Amount = amount
                },
                Customer = customer
            };

            return await _validationsApi.ValidateStackedDiscountsAsync(requestBody);
        }

        public async Task<RedemptionsRedeemResponseBody> RedeemStackedDiscounts(List<string> voucherIds)
        {
            var redeemables = new List<RedemptionsRedeemRequestBodyRedeemablesItem>();
            foreach (var voucherId in voucherIds)
            {
                var redemptionsRedeemRequestBodyRedeemablesItems = new List<RedemptionsRedeemRequestBodyRedeemablesItem>
                    {
                        new RedemptionsRedeemRequestBodyRedeemablesItem
                        {
                            Object = RedemptionsRedeemRequestBodyRedeemablesItem.ObjectEnum.Voucher,
                            Id = voucherId
                        }
                    };

                redeemables.AddRange(redemptionsRedeemRequestBodyRedeemablesItems);
            }

            var requestBody = new RedemptionsRedeemRequestBody
            {
                Redeemables = redeemables,
                Order = new Order
                {
                    Amount = 20000
                }
            };

            return await _redemptionsApi.RedeemStackedDiscountsAsync(requestBody);
        }

        public async Task<RedemptionsListResponseBody> ListRedemptions()
        {
            var filters = new ParameterFiltersListRedemptions(
                voucherCode: new ParameterFiltersListRedemptionsVoucherCode(
                    conditions: new FilterConditionsString(
                        notIn: new List<string> { "123" }
                    )
                )
            );


            return await _redemptionsApi.ListRedemptionsAsync(
                filters: filters
            );
        }
    }
}
