#if APIASYNC
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class Campaigns : EndpointBase
    {
        public Campaigns(Api api) : base(api)
        {
        }

        public async Task<DataModel.Campaign> Create(DataModel.Campaign campaign)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/campaigns/");
            return await this.client.DoPostRequest< DataModel.Campaign, DataModel.Campaign>(uriBuilder.Uri, campaign);
        }

        public async Task<DataModel.Campaign> Get(string name)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/campaigns/{0}", Uri.EscapeDataString(name)));
            return await this.client.DoGetRequest<DataModel.Campaign>(uriBuilder.Uri);
        }

        public async Task<DataModel.Voucher> AddVoucher(string name, DataModel.Contexts.CampaignAddVoucherContext addVoucherContext)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/campaigns/{0}/vouchers", Uri.EscapeDataString(name)));
            return await this.client.DoPostRequest<DataModel.Voucher, DataModel.Contexts.CampaignAddVoucherContext > (uriBuilder.Uri, addVoucherContext);
        }

        public async Task<Core.DataModel.Empty> ImportVouchers(string name, List<DataModel.Contexts.CampaignAddVoucherContext> addVoucherContext)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/campaigns/{0}/import", Uri.EscapeDataString(name)));
            return await this.client.DoPostRequest<Core.DataModel.Empty,List<DataModel.Contexts.CampaignAddVoucherContext>>(uriBuilder.Uri, addVoucherContext);
        }
    }
}
#endif