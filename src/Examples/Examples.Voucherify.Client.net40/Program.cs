using System;
using Voucherify.Client;
using DataModel = Voucherify.DataModel;

namespace Examples.Voucherify.Client.net40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[init] AppId: {0}, AppToken: {1}", args[0], args[1]);
            Api voucherifyApi = new Api(args[0], args[1], "dotNetRepoExample");

            if (args.Length > 3)
            {
                Console.WriteLine("[init] Changing Endpoint. Address: {0}", args[2]);
                voucherifyApi = voucherifyApi.WithEndpoint(args[2]);
            }

            Console.WriteLine("[run] Channel: {0}", voucherifyApi.Channel);

            voucherifyApi.Validations.ValidateVoucher(
                new DataModel.Queries.VoucherValidation()
                {
                    Code = args.Length > 3 ? args[3] : args[2]
                },
                (response) =>
                {
                    if (response.Exception != null)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("[error] Error: {0}", response.Exception);
                        Console.ResetColor();
                        return;
                    }

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("[success] Result: {0}", response.Result);
                    Console.ResetColor();
                });


            Console.WriteLine("[waiting]");
            Console.ReadKey();
        }
    }
}
