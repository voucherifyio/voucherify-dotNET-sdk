using System;
using System.Collections.Generic;
using System.Text;

namespace VoucherifyTest.net20
{
    class Program
    {
        static void Main(string[] args)
        {
            Voucherify.Client.Api apiClient = new Voucherify.Client.Api("fb1d6851-48e0-4333-9095-610b757a5793", "5e01417d-d50d-401a-b4f2-cc23909ad09c", "*")
                .WithEndpoint("api-tls12.voucherify.io/client/v1").WithSSL();

            apiClient.Validations.ValidateVoucher(
                new Voucherify.DataModel.Queries.VoucherValidation() { Code = "zZAOtkuv" },
                (response) => {
                    if (response.Exception != null)
                    {
                        Console.WriteLine("Exception: " + response.Exception.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Voucher:" + response.Result.ToString());
                    }
                });

            Voucherify.Api api = new Voucherify.Api("1f2c2d05-42d0-4c78-adee-4beb0c379a47", "485b5d2e-0604-4731-a744-1e544a69c9f1")
                .WithEndpoint("api-tls12.voucherify.io/v1").WithSSL();

            api.Validations.ValidateVoucher("zZAOtkuv", 
                new Voucherify.DataModel.Contexts.Validation(),
                (response) => {
                    if (response.Exception != null)
                    {
                        Console.WriteLine("Exception: " + response.Exception.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Voucher:" + response.Result.ToString());
                    }
                });

            Console.ReadLine();
        }
    }
}
