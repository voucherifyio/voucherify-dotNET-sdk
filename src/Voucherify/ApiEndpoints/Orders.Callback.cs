#if !APIASYNC
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class Orders : EndpointBase
    {
        public Orders(Api api) : base(api)
        {
        }

        public void Create(DataModel.Contexts.OrderCreate order, Action<ApiResponse<DataModel.Order>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/orders/");
            this.client.DoPostRequest(uriBuilder.Uri, order, callback);
        }

        public void Get(string orderId, Action<ApiResponse<DataModel.Order>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/orders/{0}", Uri.EscapeDataString(orderId)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void Update(string orderId, DataModel.Contexts.OrderUpdate order, Action<ApiResponse<DataModel.Order>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/orders/{0}", Uri.EscapeDataString(orderId)));
            this.client.DoPutRequest(uriBuilder.Uri, order, callback);
        }

        public void List(DataModel.Queries.OrderFilter filter, Action<ApiResponse<DataModel.OrderList>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/orders/"), filter);
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }
    }
}
#endif