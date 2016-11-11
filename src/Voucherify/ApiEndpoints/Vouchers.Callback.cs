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

        public void Create(DataModel.Voucher voucher, Action<ApiResponse<DataModel.Voucher>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/");
            this.client.DoPostRequest(uriBuilder.Uri, voucher, callback);
        }

        public void Create(string code, DataModel.Voucher voucher, Action<ApiResponse<DataModel.Voucher>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", Uri.EscapeDataString(code)));
            this.client.DoPostRequest(uriBuilder.Uri, voucher, callback);
        }

        public void Update(string code, DataModel.Contexts.VoucherUpdateContext voucher, Action<ApiResponse<DataModel.Voucher>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", Uri.EscapeDataString(code)));
            this.client.DoPutRequest(uriBuilder.Uri, voucher, callback);
        }

        public void Delete(string code, DataModel.Queries.VoucherDeleteQuery query, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/vouchers/{0}", Uri.EscapeDataString(code))), query);
            this.client.DoDeleteRequest(uriBuilder.Uri, callback);
        }

        public void Publish(DataModel.Queries.VoucherPublishQuery query, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/vouchers/publish"), query);
            this.client.DoPostRequest(uriBuilder.Uri, callback);
        }

        public void Publish(DataModel.Contexts.VoucherPublishContext context, Action<ApiResponse<Core.DataModel.Empty>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/publish");
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

        public void Validate(string code, DataModel.Contexts.VoucherValidationContext context, Action<ApiResponse<DataModel.Results.VoucherValidationResult>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/validate", Uri.EscapeDataString(code)));
            this.client.DoPostRequest(uriBuilder.Uri, context, callback);
        }

        public void List(DataModel.Contexts.VouchersFilterContext filter, Action<ApiResponse<IList<DataModel.Voucher>>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/vouchers/"), filter);
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void Import(List<DataModel.Voucher> vouchers, Action<ApiResponse<Core.DataModel.Empty>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/import");
            this.client.DoPostRequest(uriBuilder.Uri, vouchers, callback);
        }
    }
}
#endif