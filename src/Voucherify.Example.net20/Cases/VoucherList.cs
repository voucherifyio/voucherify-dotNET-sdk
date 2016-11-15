using System;

namespace Voucherify.Example.net20.Cases
{
    public class VoucherList
    {
        public static void Run(Voucherify.Api api)
        {
            api.Vouchers.List(
                new DataModel.Queries.VouchersFilter() { Limit = 5 }, 
                (response) => {
                    if(response.Exception != null)
                    {
                        Console.WriteLine("[VoucherList] (List) Exception: {0}", response.Exception);
                        return;
                    }

                    Console.WriteLine("[VoucherList] (List) Result: {0} First: {1}", response.Result.Count, response.Result.Count > 0 ? response.Result[0] : null);
                });
        }
    }
}
