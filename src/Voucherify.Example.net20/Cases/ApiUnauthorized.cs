using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.Example.net20.Cases
{
    public class ApiUnauthorized
    {
        public static void Run()
        {
            var serverApi = new Voucherify.Api("<invalid-app>", "<invalid-token>");

            serverApi.Vouchers.Validate(
                "<invalid_code>", 
                new DataModel.Contexts.VoucherValidation(), 
                (response) =>
                {
                    if (response.Exception != null)
                    {
                        Console.WriteLine("[ApiUnauthorized] Exception: {0}", response.Exception);
                        return;
                    }

                    Console.WriteLine("[ApiUnauthorized] Result: {0}", response.Result);
                });
        }
    }
}
