using System;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Cases
{
    public class VoucherList
    {
        public async static Task Run(Voucherify.Api api)
        {
            try
            {
                var voucherList = await api.Vouchers.List(new DataModel.Queries.VouchersFilter()
                {
                    Limit = 5
                });

                Console.WriteLine("[VoucherList] (List) Result: {0} First: {1}", voucherList.Count, voucherList.Count > 0 ? voucherList[0] : null);
            }
            catch (Exception e)
            {
                Console.WriteLine("[VoucherList] Exception: {0}", e);
            }
        }
    }
}
