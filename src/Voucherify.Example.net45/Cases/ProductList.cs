using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Cases
{
    public class ProductList
    {
        public async static Task Run(Voucherify.Api api)
        {
            try
            {
                var productList = await api.Products.List();
                Console.WriteLine("[ProductList] (List) Result: {0}", productList);
            }
            catch (Exception e)
            {
                Console.WriteLine("[ProductList] Exception: {0}", e);
            }
        }
    }
}
