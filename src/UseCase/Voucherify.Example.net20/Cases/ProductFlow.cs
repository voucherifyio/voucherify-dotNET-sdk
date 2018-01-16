using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.Example.net20.Cases
{
    public class ProductFlow
    {
        public static void Run(Voucherify.Api api)
        {
            api.Products.Create(
                new DataModel.Contexts.ProductCreate()
                {
                    Attributes = new List<string>() { "color", "size" },
                    Name = "TEST Product"
                }, (responseCreate) =>
                {
                    if (responseCreate.Exception != null)
                    {
                        Console.WriteLine("[ProductFlow] (Create) Exception: {0}", responseCreate.Exception);
                        return;
                    }

                    Console.WriteLine("[ProductFlow] (Create) Result: {0}", responseCreate.Result);
                    api.Products.Get(responseCreate.Result.Id,
                        (responseGet) =>
                        {
                            if (responseGet.Exception != null)
                            {
                                Console.WriteLine("[ProductFlow] (Get) Exception: {0}", responseGet.Exception);
                                return;
                            }

                            Console.WriteLine("[ProductFlow] (Get) Result: {0}", responseGet.Result);
                            api.Products.CreateSku(
                                responseGet.Result.Id,
                                new DataModel.Contexts.SkuCreate()
                                {
                                    SkuValue = "TEST-PRODUCT-WHITE-M",
                                    Attributes = new Core.DataModel.Metadata(new Dictionary<string, object>() {
                                        { "color", "white" },
                                        { "size", "M" }
                                    })
                                },
                                (responseCreateSku) =>
                                {
                                    if (responseCreateSku.Exception != null)
                                    {
                                        Console.WriteLine("[ProductFlow] (CreateSku) Exception: {0}", responseCreateSku.Exception);
                                        return;
                                    }

                                    Console.WriteLine("[ProductFlow] (CreateSku) Result: {0}", responseCreateSku.Result);
                                    api.Products.GetSku(
                                        responseGet.Result.Id,
                                        responseCreateSku.Result.Id,
                                        (responseGetSku) =>
                                        {
                                            if (responseCreateSku.Exception != null)
                                            {
                                                Console.WriteLine("[ProductFlow] (GetSku) Exception: {0}", responseGetSku.Exception);
                                                return;
                                            }

                                            Console.WriteLine("[ProductFlow] (GetSku) Result: {0}", responseGetSku.Result);
                                            api.Products.UpdateSku(
                                                responseGet.Result.Id,
                                                responseCreateSku.Result.Id,
                                                DataModel.Contexts.SkuUpdate.FromSku(responseGetSku.Result)
                                                    .WithCurrency("USD")
                                                    .WithPrice(100),
                                                (responseUpdateSku) =>
                                                {
                                                    if (responseUpdateSku.Exception != null)
                                                    {
                                                        Console.WriteLine("[ProductFlow] (UpdateSku) Exception: {0}", responseUpdateSku.Exception);
                                                        return;
                                                    }

                                                    Console.WriteLine("[ProductFlow] (UpdateSku) Result: {0}", responseUpdateSku.Result);
                                                    api.Products.ListSkus(
                                                        responseGet.Result.Id,
                                                        (responseListSku) =>
                                                        {
                                                            if (responseListSku.Exception != null)
                                                            {
                                                                Console.WriteLine("[ProductFlow] (ListSkus) Exception: {0}", responseListSku.Exception);
                                                                return;
                                                            }

                                                            Console.WriteLine("[ProductFlow] (ListSkus) Result: {0}", responseListSku.Result);
                                                            api.Products.DeleteSku(
                                                                responseGet.Result.Id,
                                                                responseGetSku.Result.Id,
                                                                (repsonseDeleteSku) =>
                                                                {
                                                                    if (repsonseDeleteSku.Exception != null)
                                                                    {
                                                                        Console.WriteLine("[ProductFlow] (DeleteSku) Exception: {0}", repsonseDeleteSku.Exception);
                                                                        return;
                                                                    }

                                                                    Console.WriteLine("[ProductFlow] (DeleteSku) Done}");
                                                                    api.Products.Delete(
                                                                        responseGet.Result.Id,
                                                                        (repsonseDelete) =>
                                                                        {
                                                                            if (repsonseDelete.Exception != null)
                                                                            {
                                                                                Console.WriteLine("[ProductFlow] (Delete) Exception: {0}", repsonseDelete.Exception);
                                                                                return;
                                                                            }

                                                                            Console.WriteLine("[ProductFlow] (Delete) Done}");
                                                                        });
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
