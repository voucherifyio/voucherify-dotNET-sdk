using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Client.Example.net45
{
    class Program
    {
        public static void Main(string[] args)
        {
            var clientApi = new Voucherify.Client.Api("<client_app_id>", "<client_token>", "<origin>");

            //Cases.Redeem.Run(clientApi).Wait();
            //Cases.Validate.Run(clientApi).Wait();

            Console.ReadLine();
        }
    }
}
