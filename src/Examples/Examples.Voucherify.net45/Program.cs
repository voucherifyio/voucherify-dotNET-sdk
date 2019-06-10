using System;
using Voucherify;
using System.Collections.Generic;
using DataModel = Voucherify.DataModel;
using Core = Voucherify.Core;

namespace Examples.Voucherify.net45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[init] AppId: {0}, AppToken: {1}", args[0], args[1]);
            Api voucherifyApi = new Api(args[0], args[1]).WithVersion(Core.ApiVersion.v2018_08_01);

            if (args.Length > 3)
            {
                Console.WriteLine("[init] Changing Endpoint. Address: {0}", args[2]);
                voucherifyApi = voucherifyApi.WithEndpoint(args[2]);
            }

            Console.WriteLine("[run] Channel: {0}", voucherifyApi.Channel);
            
            try
            {
                /* var result = voucherifyApi.Validations.ValidateVoucher(
                    args.Length > 3 ? args[3] : args[2],
                    new DataModel.Contexts.Validation()).GetAwaiter().GetResult(); */


                /* var result = voucherifyApi.Vouchers.Get(args.Length > 3 ? args[3] : args[2]).GetAwaiter().GetResult(); */

                var result = voucherifyApi.Redemptions.RedeemVoucher(args.Length > 3 ? args[3] : args[2], null, new DataModel.Contexts.RedemptionRedeem() {
                    Order = new DataModel.Contexts.Order().WithItems(
                        new System.Collections.Generic.List<DataModel.OrderItem>() {
                            new DataModel.OrderItem() { 
                                ProductId = "prod_6sW2N92vVRCRr8",
                                Quantity = 1
                            }
                        })
                }).GetAwaiter().GetResult();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[success] Result: {0}", result);
                Console.WriteLine("[success] Result2: {0}", result.Voucher.ApplicableTo.Entries[0]);
                Console.ResetColor();
            }
            catch (Core.Exceptions.VoucherifyClientException e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[error] Error: {0}", e);
                Console.ResetColor();
            }


            Console.WriteLine("[waiting]");
            Console.ReadKey();
        }
    }
}
