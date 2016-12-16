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

        public async Task<DataModel.Voucher> Create(DataModel.Contexts.VoucherCreate voucher)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/");
            return await this.client.DoPostRequest<DataModel.Voucher, DataModel.Contexts.VoucherCreate>(uriBuilder.Uri, voucher);
        }

        public async Task<DataModel.Voucher> Create(string code, DataModel.Contexts.VoucherCreate voucher)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", Uri.EscapeDataString(code)));
            return await this.client.DoPostRequest<DataModel.Voucher, DataModel.Contexts.VoucherCreate>(uriBuilder.Uri, voucher);
        }

        public async Task<DataModel.Voucher> Update(string code, DataModel.Contexts.VoucherUpdate voucher)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", Uri.EscapeDataString(code)));
            return await this.client.DoPutRequest< DataModel.Voucher, DataModel.Contexts.VoucherUpdate>(uriBuilder.Uri, voucher);
        }

        public async Task Delete(string code, DataModel.Queries.VoucherDelete query)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/vouchers/{0}", Uri.EscapeDataString(code))), query);
            await this.client.DoDeleteRequest(uriBuilder.Uri);
        }

        [Obsolete(message: "This method is obsolete. Use Api.Distributions.Publish() instead.", error: false)]
        public async Task Publish(DataModel.Queries.VoucherPublish query, DataModel.Contexts.VoucherPublish context)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/vouchers/publish"), query);
            await this.client.DoPostRequest<Core.DataModel.Empty, DataModel.Contexts.VoucherPublish>(uriBuilder.Uri, context);
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

        [Obsolete(message: "This method is obsolete. Use Api.Validations.ValidateVoucher() instead.", error: false)]
        public async Task<DataModel.Results.VoucherValidation> Validate(string code, DataModel.Contexts.VoucherValidation context)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/validate", Uri.EscapeDataString(code)));
            return await this.client.DoPostRequest< DataModel.Results.VoucherValidation, DataModel.Contexts.VoucherValidation>(uriBuilder.Uri, context);
        }

        public async Task<IList<DataModel.Voucher>> List(DataModel.Queries.VouchersFilter filter)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/vouchers/"), filter);
            return await this.client.DoGetRequest<IList<DataModel.Voucher>>(uriBuilder.Uri);
        }

        public async Task<Core.DataModel.Empty> Import(List<DataModel.Contexts.VoucherImport> vouchers)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/import");
            return await this.client.DoPostRequest<Core.DataModel.Empty, List<DataModel.Contexts.VoucherImport>>(uriBuilder.Uri, vouchers);
        }
    }
}
#endif