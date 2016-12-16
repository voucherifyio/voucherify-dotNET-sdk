#if !APIASYNC
using System;
using Voucherify.Core.Communication;

namespace Voucherify.ApiEndpoints
{
    public class Products : EndpointBase
    {
        public Products(Api api) : base(api)
        {
        }

        public void Create(DataModel.Contexts.ProductCreate product, Action<ApiResponse<DataModel.Product>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/products");
            this.client.DoPostRequest(uriBuilder.Uri, product, callback);
        }

        public void Get(string productId, Action<ApiResponse<DataModel.Product>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}", Uri.EscapeDataString(productId)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void Update(string productId, DataModel.Contexts.ProductUpdate product, Action<ApiResponse<DataModel.Product>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}", Uri.EscapeDataString(productId)));
            this.client.DoPutRequest(uriBuilder.Uri, product, callback);
        }

        public void List(Action<ApiResponse<DataModel.ProductList>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/products");
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void Delete(string productId, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}", Uri.EscapeDataString(productId)));
            this.client.DoDeleteRequest(uriBuilder.Uri, callback);
        }

        public void CreateSku(string productId, DataModel.Contexts.SkuCreate sku, Action<ApiResponse<DataModel.Sku>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}/skus", Uri.EscapeDataString(productId)));
            this.client.DoPostRequest(uriBuilder.Uri, sku, callback);
        }

        public void GetSku(string productId, string skuId, Action<ApiResponse<DataModel.Sku>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}/skus/{1}", Uri.EscapeDataString(productId), Uri.EscapeDataString(skuId)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void UpdateSku(string productId, string skuId, DataModel.Contexts.SkuUpdate sku, Action<ApiResponse<DataModel.Sku>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}/skus/{1}", Uri.EscapeDataString(productId), Uri.EscapeDataString(skuId)));
            this.client.DoPutRequest(uriBuilder.Uri, sku, callback);
        }

        public void DeleteSku(string productId, string skuId, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}/skus/{1}", Uri.EscapeDataString(productId), Uri.EscapeDataString(skuId)));
            this.client.DoDeleteRequest(uriBuilder.Uri, callback);
        }

        public void ListSkus(string productId, Action<ApiResponse<DataModel.ProductSkus>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}/skus", Uri.EscapeDataString(productId)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }
    }
}
#endif