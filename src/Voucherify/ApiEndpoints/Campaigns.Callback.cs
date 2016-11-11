#if !APIASYNC
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.Communication;

namespace Voucherify.ApiEndpoints
{
    public class Campaigns : EndpointBase
    {
        public Campaigns(Api api) : base(api)
        {
        }

        public void Create(DataModel.Campaign campaign, Action<ApiResponse<DataModel.Campaign>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/campaigns/");
            this.client.DoPostRequest(uriBuilder.Uri, campaign, callback);
        }

        public void Get(string name, Action<ApiResponse<DataModel.Campaign>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/campaigns/{0}", Uri.EscapeDataString(name)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        } 

        public void AddVoucher(string name, DataModel.Contexts.CampaignAddVoucherContext addVoucherContext, Action<ApiResponse<DataModel.Voucher>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/campaigns/{0}/vouchers", Uri.EscapeDataString(name)));
            this.client.DoPostRequest(uriBuilder.Uri, addVoucherContext, callback);
        }

        public void ImportVouchers(string name, List<DataModel.Contexts.CampaignAddVoucherContext> addVoucherContext, Action<ApiResponse<Core.DataModel.Empty>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/campaigns/{0}/import", Uri.EscapeDataString(name)));
            this.client.DoPostRequest(uriBuilder.Uri, addVoucherContext, callback);
        }
    }
}
#endif