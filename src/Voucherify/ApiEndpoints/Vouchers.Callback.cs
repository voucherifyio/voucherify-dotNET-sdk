#if !APIASYNC
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
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", Uri.EscapeDataString(code)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void Create(DataModel.Contexts.VoucherCreate voucher, Action<ApiResponse<DataModel.Voucher>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/");
            this.client.DoPostRequest(uriBuilder.Uri, voucher, callback);
        }

        public void Create(string code, DataModel.Contexts.VoucherCreate voucher, Action<ApiResponse<DataModel.Voucher>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", Uri.EscapeDataString(code)));
            this.client.DoPostRequest(uriBuilder.Uri, voucher, callback);
        }

        public void Update(string code, DataModel.Contexts.VoucherUpdate voucher, Action<ApiResponse<DataModel.Voucher>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", Uri.EscapeDataString(code)));
            this.client.DoPutRequest(uriBuilder.Uri, voucher, callback);
        }

        public void Delete(string code, DataModel.Queries.VoucherDelete query, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/vouchers/{0}", Uri.EscapeDataString(code))), query);
            this.client.DoDeleteRequest(uriBuilder.Uri, callback);
        }

        [Obsolete(message: "This method is obsolete. Use api.Distributions.Publish() instead.", error: false)]
        public void Publish(DataModel.Queries.VoucherPublish query, DataModel.Contexts.VoucherPublish context, Action<ApiResponse<Core.DataModel.Empty>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/vouchers/publish"), query);
            this.client.DoPostRequest(uriBuilder.Uri, context, callback);
        }

        public void Disable(string code, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/disable", Uri.EscapeDataString(code)));
            this.client.DoPostRequest(uriBuilder.Uri, callback);
        }

        public void Enable(string code, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/enable", Uri.EscapeDataString(code)));
            this.client.DoPostRequest(uriBuilder.Uri, callback);
        }

        [Obsolete(message: "This method is obsolete. Use api.Validations.ValidateVoucher() instead.", error: false)]
        public void Validate(string code, DataModel.Contexts.VoucherValidation context, Action<ApiResponse<DataModel.Results.VoucherValidation>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/validate", Uri.EscapeDataString(code)));
            this.client.DoPostRequest(uriBuilder.Uri, context, callback);
        }

        public void List(DataModel.Queries.VouchersFilter filter, Action<ApiResponse<IList<DataModel.Voucher>>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/vouchers/"), filter);
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void Import(List<DataModel.Contexts.VoucherImport> vouchers, Action<ApiResponse<Core.DataModel.Empty>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/import");
            this.client.DoPostRequest(uriBuilder.Uri, vouchers, callback);
        }
    }
}
#endif