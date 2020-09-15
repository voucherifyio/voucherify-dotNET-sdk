#if VOUCHERIFYSERVER && APIASYNC

using System;
using System.Threading.Tasks;

namespace Voucherify.ApiEndpoints
{
	public class Consents : EndpointBase
    {
        public Consents(Api api) : base(api)
        {
        }

        public async Task<DataModel.ConsentAndGroupList> List()
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/consents");
            return await this.client.DoGetRequest<DataModel.ConsentAndGroupList>(uriBuilder.Uri).ConfigureAwait(false);
        }
    }
}
#endif