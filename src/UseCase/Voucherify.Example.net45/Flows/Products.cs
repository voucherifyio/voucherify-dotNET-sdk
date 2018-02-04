using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Flows
{
    public class Products : IUseCase
    {
        public async Task Run(Voucherify.Api api)
        {
            try
            {
                var productCreated = await api.Products.Create(new DataModel.Contexts.ProductCreate()
                {
                    Attributes = new List<string>() { "color", "size" },
                    Name = "TEST Product"
                });
                Console.WriteLine("[Flows][Products] Created - Produtc: {0}", productCreated);

                var productGet = await api.Products.Get(productCreated.Id);
                Console.WriteLine("[Flows][Products] Retrieved - Product: {0}", productGet);

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

                Console.WriteLine("[Flows][Products] Created - Sku: {0}", skuCreated);

                var skuGet = await api.Products.GetSku(productGet.Id, skuCreated.Id);
                Console.WriteLine("[Flows][Products] Retrieved - Sku: {0}", skuGet);

                var skuUpdated = await api.Products.UpdateSku(
                    productGet.Id,
                    skuGet.Id,
                    DataModel.Contexts.SkuUpdate.FromSku(skuGet)
                        .WithCurrency("USD")
                        .WithPrice(100));
                Console.WriteLine("[Flows][Products] Updated - Sku: {0}", skuUpdated);

                var skuList = await api.Products.ListSkus(productGet.Id);
                Console.WriteLine("[Flows][Products] List - Skus: {0}", skuList);

                await api.Products.DeleteSku(productGet.Id, skuGet.Id);
                Console.WriteLine("[Flows][Products] Deleted Sku");
                
                var productList = await api.Products.List(new DataModel.Queries.ProductFilter() { Limit = 1 });
                Console.WriteLine("[Flows][Products] List - Products: {0}", productList);

                await api.Products.Delete(productGet.Id);
                Console.WriteLine("[Flows][Products] Deleted Product");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[Flows][Products] Ok");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Flows][Products] SomethingWentWrong: {0}", e);
                Console.ResetColor();
            }
        }
    }
}
