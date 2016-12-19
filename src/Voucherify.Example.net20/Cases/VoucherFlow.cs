using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.Example.net20.Cases
{
    public class VoucherFlow
    {
        public static void Run(Voucherify.Api api)
        {
            api.Vouchers.Create(new Voucherify.DataModel.Contexts.VoucherCreate()
            {
                Active = true,
                Category = "TEST-SDK-Category",
                AdditionalInfo = "TEST-AdditionalInfo",
                StartDate = DateTime.Now.AddDays(-1),
                ExpirationDate = DateTime.Now.AddDays(10),
                Redemption = new DataModel.Contexts.VoucherRedemption().WithQuantity(1),
                Metadata = new Core.DataModel.Metadata(new Dictionary<string, object>() {
                        { "key1", "value1" },
                        { "key2", "value2" }
                    })
            }.WithDiscount(new DataModel.Discount().WithPercentOff(69)),
                (responesCreate) =>
                {
                    if (responesCreate.Exception != null)
                    {
                        Console.WriteLine("[VoucherFlow] (Create) Exception: {0}", responesCreate.Exception);
                        return;
                    }

                    Console.WriteLine("[VoucherFlow] (Create) Result: {0}", responesCreate.Result);
                    api.Vouchers.Get(
                        responesCreate.Result.Code,
                        (responseGet) =>
                        {
                            if (responseGet.Exception != null)
                            {
                                Console.WriteLine("[VoucherFlow] (Get) Exception: {0}", responseGet.Exception);
                                return;
                            }

                            Console.WriteLine("[VoucherFlow] (Get) Result: {0}", responseGet.Result);
                            api.Vouchers.Update(
                                responseGet.Result.Code,
                                DataModel.Contexts.VoucherUpdate.FromVoucher(responseGet.Result)
                                    .WithAdditionalInfo("Some Additional Text"),
                                (responseUpdate) =>
                                {
                                    if (responseUpdate.Exception != null)
                                    {
                                        Console.WriteLine("[VoucherFlow] (Update) Exception: {0}", responseUpdate.Exception);
                                        return;
                                    }

                                    Console.WriteLine("[VoucherFlow] (Update) Result: {0}", responseUpdate.Result);
                                    api.Validations.ValidateVoucher(
                                        responseGet.Result.Code,
                                        new DataModel.Contexts.VoucherValidation() { TrackingId = "Sample Tracking Id" },
                                        (responseValidate) =>
                                        {
                                            if (responseValidate.Exception != null)
                                            {
                                                Console.WriteLine("[VoucherFlow] (Validate) Exception: {0}", responseValidate.Exception);
                                                return;
                                            }

                                            Console.WriteLine("[VoucherFlow] (Validate) Result: {0}", responseValidate.Result);
                                            api.Vouchers.Disable(
                                                responseGet.Result.Code,
                                                (responseDisable) =>
                                                {
                                                    if (responseDisable.Exception != null)
                                                    {
                                                        Console.WriteLine("[VoucherFlow] (Disable) Exception: {0}", responseDisable.Exception);
                                                        return;
                                                    }

                                                    Console.WriteLine("[VoucherFlow] (Disable) Done");
                                                    api.Vouchers.Enable(
                                                        responseGet.Result.Code,
                                                        (responseEnable) =>
                                                        {
                                                            if (responseEnable.Exception != null)
                                                            {
                                                                Console.WriteLine("[VoucherFlow] (Enable) Exception: {0}", responseEnable.Exception);
                                                                return;
                                                            }

                                                            Console.WriteLine("[VoucherFlow] (Enable) Done");
                                                            api.Vouchers.Delete(
                                                                responseGet.Result.Code,
                                                                new DataModel.Queries.VoucherDelete() { Force = true },
                                                                (responseDelete) =>
                                                                {
                                                                    if (responseDelete.Exception != null)
                                                                    {
                                                                        Console.WriteLine("[VoucherFlow] (Delete) Exception: {0}", responseDelete.Exception);
                                                                        return;
                                                                    }

                                                                    Console.WriteLine("[VoucherFlow] (Delete) Done");
                                                                });
                                                        });
                                                });
                                        });
                                });
                        });
                });
        }
    }
}
