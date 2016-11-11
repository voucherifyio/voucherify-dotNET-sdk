#if APIASYNC
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class Vouchers : EndpointBase
    {
        public Vouchers(Api api) : base(api)
        {
        }

        public async Task<DataModel.Voucher> Get(string code)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", Uri.EscapeDataString(code)));
            return await this.client.DoGetRequest<DataModel.Voucher>(uriBuilder.Uri);
        }

        public async Task<DataModel.Voucher> Create(DataModel.Voucher voucher)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/");
            return await this.client.DoPostRequest<DataModel.Voucher, DataModel.Voucher>(uriBuilder.Uri, voucher);
        }

        public async Task<DataModel.Voucher> Create(string code, DataModel.Voucher voucher)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", Uri.EscapeDataString(code)));
            return await this.client.DoPostRequest<DataModel.Voucher, DataModel.Voucher>(uriBuilder.Uri, voucher);
        }

        public async Task<DataModel.Voucher> Update(string code, DataModel.Contexts.VoucherUpdateContext voucher)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", Uri.EscapeDataString(code)));
            return await this.client.DoPutRequest< DataModel.Voucher, DataModel.Contexts.VoucherUpdateContext>(uriBuilder.Uri, voucher);
        }

        public async Task Delete(string code, DataModel.Queries.VoucherDeleteQuery query)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/vouchers/{0}", Uri.EscapeDataString(code))), query);
            await this.client.DoDeleteRequest(uriBuilder.Uri);
        }

        public async Task Publish(DataModel.Queries.VoucherPublishQuery query)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/vouchers/publish"), query);
            await this.client.DoPostRequest(uriBuilder.Uri);
        }

        public async Task<Core.DataModel.Empty> Publish(DataModel.Contexts.VoucherPublishContext context)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/publish");
            return await this.client.DoPostRequest<Core.DataModel.Empty, DataModel.Contexts.VoucherPublishContext>(uriBuilder.Uri, context);
        }

        public async Task Disable(string code)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/disable", Uri.EscapeDataString(code)));
            await this.client.DoPostRequest(uriBuilder.Uri);
        }

        public async Task Enable(string code)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/enable", Uri.EscapeDataString(code)));
            await this.client.DoPostRequest(uriBuilder.Uri);
        }

        public async Task<DataModel.Results.VoucherValidationResult> Validate(string code, DataModel.Contexts.VoucherValidationContext context)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/validate", Uri.EscapeDataString(code)));
            return await this.client.DoPostRequest< DataModel.Results.VoucherValidationResult, DataModel.Contexts.VoucherValidationContext>(uriBuilder.Uri, context);
        }

        public async Task<IList<DataModel.Voucher>> List(DataModel.Contexts.VouchersFilterContext filter)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/vouchers/"), filter);
            return await this.client.DoGetRequest<IList<DataModel.Voucher>>(uriBuilder.Uri);
        }

        public async Task<Core.DataModel.Empty> Import(List<DataModel.Voucher> vouchers)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/import");
            return await this.client.DoPostRequest<Core.DataModel.Empty, List<DataModel.Voucher>>(uriBuilder.Uri, vouchers);
        }
    }
}
#endif