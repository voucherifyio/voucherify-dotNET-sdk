#if VOUCHERIFYSERVER && APIASYNC
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class Orders : EndpointBase
    {
        public Orders(Api api) : base(api)
        {
        }

        public async Task<DataModel.Order> Create(DataModel.Contexts.OrderCreate order)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/orders/");
            return await this.client.DoPostRequest<DataModel.Order, DataModel.Contexts.OrderCreate>(uriBuilder.Uri, order).ConfigureAwait(false);
        }

        public async Task<DataModel.Order> Get(string orderId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/orders/{0}", UriBuilderExtension.EnsureEscapedDataString("orderId", orderId)));
            return await this.client.DoGetRequest<DataModel.Order>(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.Order> Update(string orderId, DataModel.Contexts.OrderUpdate order)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/orders/{0}", UriBuilderExtension.EnsureEscapedDataString("orderId", orderId)));
            return await this.client.DoPutRequest<DataModel.Order, DataModel.Contexts.OrderUpdate>(uriBuilder.Uri, order).ConfigureAwait(false);
        }

        public async Task<DataModel.OrderList> List(DataModel.Queries.OrderFilter filter)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/orders/"), filter);
            return await this.client.DoGetRequest<DataModel.OrderList>(uriBuilder.Uri).ConfigureAwait(false);
        }
    }
}
#endif