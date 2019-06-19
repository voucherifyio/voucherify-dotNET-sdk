using System;
using Voucherify;
using DataModel = Voucherify.DataModel;

namespace Examples.Voucherify.net20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[init] AppId: {0}, AppToken: {1}", args[0], args[1]);
            Api voucherifyApi = new Api(args[0], args[1]);

            if (args.Length > 3)
            {
                Console.WriteLine("[init] Changing Host. Address: {0}", args[2]);
                voucherifyApi = voucherifyApi.WithHost(args[2]);
            }

            Console.WriteLine("[run] Channel: {0}", voucherifyApi.Channel);

            voucherifyApi.Validations.ValidateVoucher(
                args.Length > 3 ? args[3] : args[2],
                new DataModel.Contexts.Validation(),
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
