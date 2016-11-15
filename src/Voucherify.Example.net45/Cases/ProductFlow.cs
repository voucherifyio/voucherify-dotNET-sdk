using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Cases
{
    public class ProductFlow
    {
        public async static Task Run(Voucherify.Api api)
        {
            try
            {
                var productCreated = await api.Products.Create(new DataModel.Contexts.ProductCreate()
                {
                    Attributes = new List<string>() { "color", "size" },
                    Name = "TEST Product"
                });
                Console.WriteLine("[ProductFlow] (Create) Result: {0}", productCreated);
                var productGet = await api.Products.Get(productCreated.Id);
                Console.WriteLine("[ProductFlow] (Get) Result: {0}", productGet);
                var skuCreated = await api.Products.CreateSku(
                    productGet.Id,
                    new DataModel.Contexts.SkuCreate()
                    {
                        SkuValue = "TEST-PRODUCT-WHITE-M",
                        Attributes = new Core.DataModel.Metadata(new Dictionary<string, object>() {
                            { "color", "white" },
                            { "size", "M" }
                        })
                    });
                Console.WriteLine("[ProductFlow] (CreateSku) Result: {0}", skuCreated);
                var skuGet = await api.Products.GetSku(productGet.Id, skuCreated.Id);
                Console.WriteLine("[ProductFlow] (GetSku) Exception: {0}", skuGet);
                var skuUpdated = await api.Products.UpdateSku(
                    productGet.Id,
                    skuGet.Id,
                    DataModel.Contexts.SkuUpdate.FromSku(skuGet)
                        .WithCurrency("USD")
                        .WithPrice(100));
                Console.WriteLine("[ProductFlow] (UpdateSku) Result: {0}", skuUpdated);
                var skuList = await api.Products.ListSkus(productGet.Id);
                Console.WriteLine("[ProductFlow] (ListSkus) Result: {0}", skuList);
                await api.Products.DeleteSku(productGet.Id, skuGet.Id);
                Console.WriteLine("[ProductFlow] (DeleteSku) Done}");
                await api.Products.Delete(productGet.Id);
                Console.WriteLine("[ProductFlow] (Delete) Done}");
            }
            catch (Exception e)
            {
                Console.WriteLine("[ProductFlow] Exception: {0}", e);
            }         
        }
    }
}
