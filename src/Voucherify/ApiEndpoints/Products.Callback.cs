#if VOUCHERIFYSERVER && !APIASYNC
using System;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;

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
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}", UriBuilderExtension.EnsureEscapedDataString("productId", productId)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void Update(string productId, DataModel.Contexts.ProductUpdate product, Action<ApiResponse<DataModel.Product>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}", UriBuilderExtension.EnsureEscapedDataString("productId", productId)));
            this.client.DoPutRequest(uriBuilder.Uri, product, callback);
        }

        public void List(DataModel.Queries.ProductFilter filter, Action<ApiResponse<DataModel.ProductList>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/products/"), filter);
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void Delete(string productId, Action<ApiResponse> callback)
        {
            this.Delete(productId, null, callback);
        }

        public void Delete(string productId, Core.DataModel.ForcedOperation query, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/products/{0}", UriBuilderExtension.EnsureEscapedDataString("productId", productId))), query);
            this.client.DoDeleteRequest(uriBuilder.Uri, callback);
        }

        public void CreateSku(string productId, DataModel.Contexts.SkuCreate sku, Action<ApiResponse<DataModel.Sku>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}/skus", UriBuilderExtension.EnsureEscapedDataString("productId", productId)));
            this.client.DoPostRequest(uriBuilder.Uri, sku, callback);
        }

        public void GetSku(string productId, string skuId, Action<ApiResponse<DataModel.Sku>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}/skus/{1}", UriBuilderExtension.EnsureEscapedDataString("productId", productId), UriBuilderExtension.EnsureEscapedDataString("skuId", skuId)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void UpdateSku(string productId, string skuId, DataModel.Contexts.SkuUpdate sku, Action<ApiResponse<DataModel.Sku>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}/skus/{1}", UriBuilderExtension.EnsureEscapedDataString("productId", productId), UriBuilderExtension.EnsureEscapedDataString("skuId", skuId)));
            this.client.DoPutRequest(uriBuilder.Uri, sku, callback);
        }

        public void DeleteSku(string productId, string skuId, Action<ApiResponse> callback)
        {
            this.DeleteSku(productId, skuId, null, callback);
        }

        public void DeleteSku(string productId, string skuId, Core.DataModel.ForcedOperation query, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/products/{0}/skus/{1}", UriBuilderExtension.EnsureEscapedDataString("productId", productId), UriBuilderExtension.EnsureEscapedDataString("skuId", skuId))), query);
            this.client.DoDeleteRequest(uriBuilder.Uri, callback);
        }

        public void ListSkus(string productId, Action<ApiResponse<DataModel.ProductSkuList>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/products/{0}/skus", UriBuilderExtension.EnsureEscapedDataString("productId", productId)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }
    }
}
#endif