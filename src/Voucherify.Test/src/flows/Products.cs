using System;
using System.Threading.Tasks;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;
using System.Collections.Generic;

namespace Voucherify.Test
{
    public class ProductsFlow
    {
        private readonly ProductsApi _productsApi;

        public ProductsFlow()
        {
            _productsApi = new ProductsApi(TestConfiguration.GetClientConfiguration());
        }

        public async Task<ProductsCreateResponseBody> createProduct(int price)
        {
            var productsCreateRequestBody = new ProductsCreateRequestBody
            {
                Name = TestHelper.GenerateRandomString(),
                Price = price,
                SourceId = TestHelper.GenerateRandomString(),
                Attributes = new System.Collections.Generic.List<string> { "color", "memory", "processor" }
            };

            return await _productsApi.CreateProductAsync(productsCreateRequestBody);
        }

        public async Task<ProductsGetResponseBody> getProduct(string productId)
        {
            return await _productsApi.GetProductAsync(productId);
        }

        public async Task<ProductsUpdateResponseBody> updateProduct(string productId, int newPrice)
        {
            var update = new ProductsUpdateRequestBody
            {
                Price = newPrice
            };

            return await _productsApi.UpdateProductAsync(productId, update);
        }

        public async Task<ProductsListResponseBody> listProducts()
        {
            return await _productsApi.ListProductsAsync();
        }

        public async Task<ProductsUpdateInBulkResponseBody> updateProductInBulk()
        {
            var productsUpdateInBulkRequestBody = new System.Collections.Generic.List<ProductsUpdateInBulkRequestBody>
            {
                new ProductsUpdateInBulkRequestBody
                {
                    SourceId = TestHelper.GenerateRandomString(),
                    Price = 1000
                },
                new ProductsUpdateInBulkRequestBody
                {
                    SourceId = TestHelper.GenerateRandomString(),
                    Price = 2000
                }
            };

            return await _productsApi.UpdateProductsInBulkAsync(productsUpdateInBulkRequestBody);
        }

        public async Task<ProductsMetadataUpdateInBulkResponseBody> updateProductMetadataInBulk(System.Collections.Generic.List<string> productIds)
        {
            var productsMetadataUpdateInBulkRequestBody = new ProductsMetadataUpdateInBulkRequestBody
            {
                SourceIds = productIds,
                Metadata = new System.Collections.Generic.Dictionary<string, object>
                {
                    { "key1", "value1" },
                    { "key2", "value2" }
                }
            };

            return await _productsApi.UpdateProductsMetadataInBulkAsync(productsMetadataUpdateInBulkRequestBody);
        }

        public async Task<ProductsSkusCreateResponseBody> createSku(string productId, int price)
        {
            var productsSkusCreateRequestBody = new ProductsSkusCreateRequestBody
            {
                Sku = TestHelper.GenerateRandomString(),
                Price = price,
                SourceId = TestHelper.GenerateRandomString(),
                Attributes = new System.Collections.Generic.Dictionary<string, object>
                {
                    { "color", "red" },
                    { "memory", "16GB" },
                    { "processor", "Intel Core i7" }
                }
            };

            return await _productsApi.CreateSkuAsync(productId, productsSkusCreateRequestBody);
        }

        public async Task<ProductsSkusUpdateResponseBody> updateSku(string productId, string skuId, int newPrice)
        {
            var productsSkusUpdateRequestBody = new ProductsSkusUpdateRequestBody
            {
                Price = newPrice
            };

            return await _productsApi.UpdateSkuAsync(productId, skuId, productsSkusUpdateRequestBody);
        }

        public async Task<SkusGetResponseBody> getSku(string skuId)
        {
            return await _productsApi.GetSkuAsync(skuId);
        }

        public async Task<ProductsSkusListResponseBody> listSkusInProduct(string productId)
        {
            return await _productsApi.ListSkusInProductAsync(productId);
        }

        public async Task deleteProduct(string productId)
        {
            await _productsApi.DeleteProductAsync(productId, true);
        }

        public async Task deleteSku(string productId, string skuId)
        {
            await _productsApi.DeleteSkuAsync(productId, skuId, true);
        }
    }
} 