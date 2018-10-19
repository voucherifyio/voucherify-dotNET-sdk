extern alias Client;
extern alias Server;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherifyTest.net45
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args)
        {
            try
            {
                Client.Voucherify.Client.Api apiClient = new Client.Voucherify.Client.Api("fb1d6851-48e0-4333-9095-610b757a5793", "5e01417d-d50d-401a-b4f2-cc23909ad09c", "*")
                       .WithEndpoint("api-tls12.voucherify.io/client/v1").WithSSL();

                var responseClient = await apiClient.Validations.ValidateVoucher(new Client.Voucherify.DataModel.Queries.VoucherValidation() { Code = "zZAOtkuv" });

                Console.WriteLine("Voucher:" + responseClient.ToString());
            }
            catch (Client.Voucherify.Core.Exceptions.VoucherifyClientException exClient)
            {
                Console.WriteLine("Exception: " + exClient.ToString());

            }

            Server.Voucherify.Api api = new Server.Voucherify.Api("1f2c2d05-42d0-4c78-adee-4beb0c379a47", "485b5d2e-0604-4731-a744-1e544a69c9f1")
                .WithEndpoint("api.voucherify.io/v1").WithSSL();

            try
            {
                var response = await api.Validations.ValidateVoucher("zZAOtkuv", new Server.Voucherify.DataModel.Contexts.Validation());
                Console.WriteLine("Voucher:" + response.ToString());
            }
            catch (Server.Voucherify.Core.Exceptions.VoucherifyClientException exClient)
            {
                Console.WriteLine("Exception: " + exClient.ToString());

            }

            Console.ReadLine();
        }
    }
}
