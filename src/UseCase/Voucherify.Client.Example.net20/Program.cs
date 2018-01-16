using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.Client.Example.net20
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientApi = new Voucherify.Client.Api("<client_app_id>", "<client_token>", "<origin>");

            //Cases.Redeem.Run(clientApi);
            //Cases.Validate.Run(clientApi);

            Console.ReadLine();
        }
    }
}
