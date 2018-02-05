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

        public async Task<DataModel.Segment> Get(string segmentId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/segments/{0}", Uri.EscapeDataString(segmentId)));
            return await this.client.DoGetRequest<DataModel.Segment>(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.Segment> Create(DataModel.Contexts.SegmentCreate voucher)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/segments/");
            return await this.client.DoPostRequest< DataModel.Segment,DataModel.Contexts.SegmentCreate>(uriBuilder.Uri, voucher).ConfigureAwait(false);
        }

        public async Task Delete(string segmentId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/segments/{0}", Uri.EscapeDataString(segmentId)));
            await this.client.DoDeleteRequest(uriBuilder.Uri).ConfigureAwait(false);
        }
    }
}
#endif