#if APIASYNC
using System;
using System.Threading.Tasks;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class Products : EndpointBase
    {
        public Products(Api api) : base(api)
        {
        }

        public async Task<DataModel.Product> Create(DataModel.Product product)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/products");
            return await this.client.DoPostRequest<DataModel.Product, DataModel.Product>(uriBuilder.Uri, product);
        }

        public async Task<DataModel.Product> Get(string productId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}", Uri.EscapeDataString(productId)));
            return await this.client.DoGetRequest<DataModel.Product>(uriBuilder.Uri);
        }

        public async Task<DataModel.ProductList> List()
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/products");
            return await this.client.DoGetRequest< DataModel.ProductList>(uriBuilder.Uri);
        }

        public async Task Delete(string productId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/product/{0}", Uri.EscapeDataString(productId)));
            await this.client.DoDeleteRequest(uriBuilder.Uri);
        }

        public async Task<DataModel.Sku> CreateSku(string productId, DataModel.Sku sku)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}", Uri.EscapeDataString(productId)));
            return await this.client.DoPostRequest<DataModel.Sku, DataModel.Sku>(uriBuilder.Uri, sku);
        }

        public async Task<DataModel.Sku> GetSku(string productId, string skuId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}/skus/{1}", Uri.EscapeDataString(productId), Uri.EscapeDataString(skuId)));
            return await this.client.DoGetRequest<DataModel.Sku>(uriBuilder.Uri);
        }

        public async Task<DataModel.Sku> UpdateSku(string productId, string skuId, DataModel.Contexts.SkuUpdateContext sku)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}/skus/{1}", Uri.EscapeDataString(productId), Uri.EscapeDataString(skuId)));
            return await this.client.DoPutRequest<DataModel.Sku, DataModel.Contexts.SkuUpdateContext>(uriBuilder.Uri, sku);
        }

        public async Task DeleteSku(string productId, string skuId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}/skus/{1}", Uri.EscapeDataString(productId), Uri.EscapeDataString(skuId)));
            await this.client.DoDeleteRequest(uriBuilder.Uri);
        }

        public async Task<DataModel.ProductSkus> ListSkus(string productId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}", Uri.EscapeDataString(productId)));
            return await this.client.DoGetRequest< DataModel.ProductSkus>(uriBuilder.Uri);
        }
    }
}
#endif