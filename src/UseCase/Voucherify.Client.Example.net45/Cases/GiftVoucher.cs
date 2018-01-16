using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Client.Example.net45.Cases
{
    public class GiftVoucher
    {
        public async static Task Run(Voucherify.Client.Api api, string voucherCode, int amount)
        {
            try
            {
                var validation = await api.Validations.ValidateVoucher(new DataModel.Queries.VoucherValidation() {
                    Code = voucherCode,
                    Amount = amount
                }).ConfigureAwait(false);
                Console.WriteLine("[Validate]  Result: {0}", validation);

                var redemption = await api.Redemptions.Redeem(
                    new DataModel.Queries.RedemptionRedeem() {
                        Code = voucherCode
                    },
                    new DataModel.Contexts.RedemptionRedeem() {
                        Order = new DataModel.Order().WithAmount(amount)
                    }.WithCustomerId("customer@test.com"));
                Console.WriteLine("[Redeem]  Result: {0}", redemption);
            }
            catch (Exception e)
            {
                Console.WriteLine("[Redeem]  Exception: {0}", e);
            }
        }
    }
}
