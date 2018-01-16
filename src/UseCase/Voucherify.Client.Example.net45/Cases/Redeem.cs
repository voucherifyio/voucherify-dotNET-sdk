using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Client.Example.net45.Cases
{
    public class Redeem
    {
        public async static Task Run(Voucherify.Client.Api api)
        {
            try
            {
                var redemption = await api.Redemptions.Redeem(
                    new DataModel.Queries.RedemptionRedeem() { Code = "<voucher_code>" },
                    new DataModel.Contexts.RedemptionRedeem().WithCustomerId("customer@test.com"));
                Console.WriteLine("[Redeem]  Result: {0}", redemption);
            }
            catch (Exception e)
            {
                Console.WriteLine("[Redeem]  Exception: {0}", e);
            }
        }
    }
}
