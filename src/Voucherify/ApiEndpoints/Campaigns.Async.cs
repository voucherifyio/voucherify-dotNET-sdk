#if VOUCHERIFYSERVER && APIASYNC
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

        public async Task<DataModel.Campaign> Create(DataModel.Contexts.CampaignCreate campaign)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/campaigns/");
            return await this.client.DoPostRequest<DataModel.Campaign, DataModel.Contexts.CampaignCreate>(uriBuilder.Uri, campaign).ConfigureAwait(false);
        }

        public async Task<DataModel.Campaign> Get(string name)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/campaigns/{0}", Uri.EscapeDataString(name)));
            return await this.client.DoGetRequest<DataModel.Campaign>(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.Campaign> Update(string name, DataModel.Contexts.CampaignUpdate campaign)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/campaigns/{0}", Uri.EscapeDataString(name)));
            return await this.client.DoPutRequest<DataModel.Campaign, DataModel.Contexts.CampaignUpdate>(uriBuilder.Uri, campaign).ConfigureAwait(false);
        }

        public async Task Delete(string name, DataModel.Queries.CampaignDelete query)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/campaigns/{0}", Uri.EscapeDataString(name))), query);
            await this.client.DoDeleteRequest(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.Voucher> AddVoucher(string name, DataModel.Contexts.CampaignAddVoucher addVoucherContext)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/campaigns/{0}/vouchers", Uri.EscapeDataString(name)));
            return await this.client.DoPostRequest<DataModel.Voucher, DataModel.Contexts.CampaignAddVoucher>(uriBuilder.Uri, addVoucherContext).ConfigureAwait(false);
        }

        public async Task<Core.DataModel.Empty> ImportVouchers(string name, List<DataModel.Contexts.CampaignVoucherImport> addVoucherContext)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/campaigns/{0}/import", Uri.EscapeDataString(name)));
            return await this.client.DoPostRequest<Core.DataModel.Empty, List<DataModel.Contexts.CampaignVoucherImport>>(uriBuilder.Uri, addVoucherContext).ConfigureAwait(false);
        }

        public async Task<DataModel.CampaignList> List(DataModel.Queries.CampaignFilter filter)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/campaigns/"), filter);
            return await this.client.DoGetRequest<DataModel.CampaignList>(uriBuilder.Uri).ConfigureAwait(false);
        }
    }
}
#endif