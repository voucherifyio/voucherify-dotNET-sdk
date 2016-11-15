using System;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Cases
{
    public class RedemptionList
    {
        public async static Task Run(Voucherify.Api api)
        {
            try
            {
                var redemptionList = await api.Redemptions.List(new DataModel.Queries.RedemptionsFilter() { Limit = 5 });
                Console.WriteLine("[RedemptionList] (List) Result: {0} First: {1}", redemptionList.Total, redemptionList.Total > 0 ? redemptionList.Redemptions[0] : null);
            }
            catch (Exception e)
            {
                Console.WriteLine("[RedemptionList] Exception: {0}", e);
            }
        }
    }
}
