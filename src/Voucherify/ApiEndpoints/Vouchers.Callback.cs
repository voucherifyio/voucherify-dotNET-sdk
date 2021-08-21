#if VOUCHERIFYSERVER && !APIASYNC
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;
using DataModel = Voucherify.DataModel;

namespace Voucherify.ApiEndpoints
{
    public class Vouchers : EndpointBase
    {
        public Vouchers(Api api) : base(api)
        {
        }

        public void Get(string code, Action<ApiResponse<DataModel.Voucher>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", UriBuilderExtension.EnsureEscapedDataString("code", code)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void Create(DataModel.Contexts.VoucherCreate voucher, Action<ApiResponse<DataModel.Voucher>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/");
            this.client.DoPostRequest(uriBuilder.Uri, voucher, callback);
        }

        public void Create(string code, DataModel.Contexts.VoucherCreate voucher, Action<ApiResponse<DataModel.Voucher>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", UriBuilderExtension.EnsureEscapedDataString("code", code)));
            this.client.DoPostRequest(uriBuilder.Uri, voucher, callback);
        }

        public void Update(string code, DataModel.Contexts.VoucherUpdate voucher, Action<ApiResponse<DataModel.Voucher>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", UriBuilderExtension.EnsureEscapedDataString("code", code)));
            this.client.DoPutRequest(uriBuilder.Uri, voucher, callback);
        }

        public void AddGiftBalance(string code, DataModel.Contexts.VoucherAddGiftBalance balance, Action<ApiResponse<DataModel.Balance>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/balance", UriBuilderExtension.EnsureEscapedDataString("code", code)));
            this.client.DoPostRequest(uriBuilder.Uri, balance, callback);
        }

        public void Delete(string code, Action<ApiResponse> callback)
        {
            this.Delete(code, null, callback);
        }

        public void Delete(string code, Core.DataModel.ForcedOperation query, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/vouchers/{0}", UriBuilderExtension.EnsureEscapedDataString("code", code))), query);
            this.client.DoDeleteRequest(uriBuilder.Uri, callback);
        }

        public void Disable(string code, Action<ApiResponse<DataModel.Voucher>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/disable", UriBuilderExtension.EnsureEscapedDataString("code", code)));
            this.client.DoPostRequest(uriBuilder.Uri, callback);
        }

        public void Enable(string code, Action<ApiResponse<DataModel.Voucher>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/enable", UriBuilderExtension.EnsureEscapedDataString("code", code)));
            this.client.DoPostRequest(uriBuilder.Uri, callback);
        }

        public void List(DataModel.Queries.VouchersFilter filter, Action<ApiResponse<DataModel.VoucherList>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/vouchers/"), filter);
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void Import(List<DataModel.Contexts.VoucherImport> vouchers, Action<ApiResponse<Core.DataModel.Empty>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/import");
            this.client.DoPostRequest(uriBuilder.Uri, vouchers, callback);
        }

        public void DeleteSession(string code, String sessionId, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/sessions/{1}", UriBuilderExtension.EnsureEscapedDataString("code", code), UriBuilderExtension.EnsureEscapedDataString("sessionId", sessionId)));
            this.client.DoDeleteRequest(uriBuilder.Uri, callback);
        }
    }
}
#endif