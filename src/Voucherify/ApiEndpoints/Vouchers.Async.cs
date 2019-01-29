#if VOUCHERIFYSERVER && APIASYNC
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
            return await this.client.DoGetRequest<DataModel.Voucher>(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.Voucher> Create(DataModel.Contexts.VoucherCreate voucher)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/");
            return await this.client.DoPostRequest<DataModel.Voucher, DataModel.Contexts.VoucherCreate>(uriBuilder.Uri, voucher).ConfigureAwait(false);
        }

        public async Task<DataModel.Voucher> Create(string code, DataModel.Contexts.VoucherCreate voucher)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", Uri.EscapeDataString(code)));
            return await this.client.DoPostRequest<DataModel.Voucher, DataModel.Contexts.VoucherCreate>(uriBuilder.Uri, voucher).ConfigureAwait(false);
        }

        public async Task<DataModel.Voucher> Update(string code, DataModel.Contexts.VoucherUpdate voucher)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", Uri.EscapeDataString(code)));
            return await this.client.DoPutRequest< DataModel.Voucher, DataModel.Contexts.VoucherUpdate>(uriBuilder.Uri, voucher).ConfigureAwait(false);
        }

        public async Task<DataModel.Balance> AddGiftBalance(string code, DataModel.Contexts.VoucherAddGiftBalance balance)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/balance", Uri.EscapeDataString(code)));
            return await this.client.DoPostRequest<DataModel.Balance, DataModel.Contexts.VoucherAddGiftBalance>(uriBuilder.Uri, balance).ConfigureAwait(false);
        }

        public async Task Delete(string code)
        {
            await this.Delete(code, null);
        }

        public async Task Delete(string code, Core.DataModel.ForcedOperation query)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/vouchers/{0}", Uri.EscapeDataString(code))), query);
            await this.client.DoDeleteRequest(uriBuilder.Uri).ConfigureAwait(false);
        }
        
        public async Task<DataModel.Voucher> Disable(string code)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/disable", Uri.EscapeDataString(code)));
            return await this.client.DoPostRequest<DataModel.Voucher>(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.Voucher> Enable(string code)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/enable", Uri.EscapeDataString(code)));
            return await this.client.DoPostRequest<DataModel.Voucher>(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.VoucherList> List(DataModel.Queries.VouchersFilter filter)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/vouchers/"), filter);
            return await this.client.DoGetRequest<DataModel.VoucherList>(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<Core.DataModel.Empty> Import(List<DataModel.Contexts.VoucherImport> vouchers)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/import");
            return await this.client.DoPostRequest<Core.DataModel.Empty, List<DataModel.Contexts.VoucherImport>>(uriBuilder.Uri, vouchers).ConfigureAwait(false);
        }
    }
}
#endif