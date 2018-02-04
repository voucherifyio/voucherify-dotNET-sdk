#if !APIASYNC
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class Campaigns : EndpointBase
    {
        public Campaigns(Api api) : base(api)
        {
        }

        public void Create(DataModel.Contexts.CampaignCreate campaign, Action<ApiResponse<DataModel.Campaign>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/campaigns/");
            this.client.DoPostRequest(uriBuilder.Uri, campaign, callback);
        }

        public void Get(string name, Action<ApiResponse<DataModel.Campaign>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/campaigns/{0}", Uri.EscapeDataString(name)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void Update(string name, DataModel.Contexts.CampaignUpdate campaign, Action<ApiResponse<DataModel.Campaign>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/campaigns/{0}", Uri.EscapeDataString(name)));
            this.client.DoPutRequest(uriBuilder.Uri, campaign, callback);
        }

        public void Delete(string name, DataModel.Queries.CampaignDelete query, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/campaigns/{0}", Uri.EscapeDataString(name))), query);
            this.client.DoDeleteRequest(uriBuilder.Uri, callback);
        }

        public void AddVoucher(string name, DataModel.Contexts.CampaignAddVoucher addVoucherContext, Action<ApiResponse<DataModel.Voucher>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/campaigns/{0}/vouchers", Uri.EscapeDataString(name)));
            this.client.DoPostRequest(uriBuilder.Uri, addVoucherContext, callback);
        }

        public void ImportVouchers(string name, List<DataModel.Contexts.CampaignVoucherImport> addVoucherContext, Action<ApiResponse<Core.DataModel.Empty>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/campaigns/{0}/import", Uri.EscapeDataString(name)));
            this.client.DoPostRequest(uriBuilder.Uri, addVoucherContext, callback);
        }

        public void List(DataModel.Queries.CampaignFilter filter, Action<ApiResponse<DataModel.CampaignList>> callback)
        {
            UriBuilder uriBuilder =  UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/campaigns/"), filter);
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }
    }
}
#endif