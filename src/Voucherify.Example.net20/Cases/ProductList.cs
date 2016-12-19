using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.Example.net20.Cases
{
    public class ProductList
    {
        public static void Run(Voucherify.Api api)
        {
            api.Products.List((response) =>
            {
                if (response.Exception != null)
                {
                    Console.WriteLine("[ProductList] (List) Exception: {0}", response.Exception);
                    return;
                }

                Console.WriteLine("[ProductList] (List) Result: {0}", response.Result);
            });
        }
    }
}
