#if APIASYNC
using System;
using System.Threading.Tasks;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class Segments : EndpointBase
    {
        public Segments(Api api) : base(api)
        {
        }

        public async Task<DataModel.Segment> Get(string validationRuleId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}", Uri.EscapeDataString(validationRuleId)));
            return await this.client.DoGetRequest<DataModel.Segment>(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.Segment> Create(DataModel.Contexts.SegmentCreate voucher)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/validation-rules/");
            return await this.client.DoPostRequest< DataModel.Segment,DataModel.Contexts.SegmentCreate>(uriBuilder.Uri, voucher).ConfigureAwait(false);
        }


        public async Task Delete(string validationRuleId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}", Uri.EscapeDataString(validationRuleId)));
            await this.client.DoDeleteRequest(uriBuilder.Uri).ConfigureAwait(false);
        }
    }
}
#endif