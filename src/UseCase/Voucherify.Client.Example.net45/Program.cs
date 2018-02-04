using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Client.Example.net45
{
    class Program
    {
        static void Main(string[] args)
        {
            string applicationId = args.Length > 0 ? args[0] : "";
            string applicationSecret = args.Length > 1 ? args[1] : "";
            string applicationOrigin = args.Length > 2 ? args[2] : "";

            var clientApi = new Voucherify.Client.Api(applicationId, applicationSecret, applicationOrigin);

            IUseCase[] useCases = new IUseCase[]
            {
                new Vouchers.Redeem(),
                new Vouchers.Validate()
            };

            Console.WriteLine("Started.");

            foreach (IUseCase useCase in useCases)
            {
                useCase.Run(clientApi).Wait();
            }

            Console.WriteLine("Finalized. Press any key to continue.");
            Console.ReadLine();
        }
    }
}
