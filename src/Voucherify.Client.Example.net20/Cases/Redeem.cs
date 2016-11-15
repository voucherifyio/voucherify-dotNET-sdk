using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.Client.Example.net20.Cases
{
    public class Redeem
    {
        public static void Run(Voucherify.Client.Api api)
        {
            api.Redemptions.Redeem(
                new DataModel.Queries.RedemptionRedeem() { Code = "<voucher_code>" },
                new DataModel.Contexts.RedemptionRedeem().WithCustomerId("customer@test.com"),
                (response) => {
                    if (response.Exception != null)
                    {
                        Console.WriteLine("[Redeem]  Exception: {0}", response.Exception);
                        return;
                    }

                    Console.WriteLine("[Redeem]  Result: {0}", response.Result);
                });
        }
    }
}
