using System;

namespace Voucherify.Example.net20.Cases
{
    public class CampaignList
    {
        public static void Run(Voucherify.Api api)
        {
            api.Campaigns.List(
                new DataModel.Queries.CampaignFilter() { Limit = 5 },
                (response) =>
                {
                    if (response.Exception != null)
                    {
                        Console.WriteLine("[CampaignList] (List) Exception: {0}", response.Exception);
                        return;
                    }

                    Console.WriteLine("[CampaignList] (List) Result: {0} First: {1}", response.Result.Total, response.Result.Total > 0 ? response.Result.Campaigns[0] : null);
                });
        }
    }
}
