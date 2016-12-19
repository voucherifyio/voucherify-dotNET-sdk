using System;

namespace Voucherify.Example.net20.Cases
{
    public class RedemptionList
    {
        public static void Run(Voucherify.Api api)
        {
            api.Redemptions.List(
                new DataModel.Queries.RedemptionsFilter() { Limit = 5 },
                (response) =>
                {
                    if (response.Exception != null)
                    {
                        Console.WriteLine("[RedemptionList] (List) Exception: {0}", response.Exception);
                        return;
                    }

                    Console.WriteLine("[RedemptionList] (List) Result: {0} First: {1}", response.Result.Total, response.Result.Total > 0 ? response.Result.Redemptions[0] : null);
                });
        }
    }
}
