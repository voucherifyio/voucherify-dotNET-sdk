#if VOUCHERIFYSERVER && !APIASYNC
using System;
using Voucherify.Core.Communication;
using DataModel = Voucherify.DataModel;

namespace Voucherify.ApiEndpoints
{
    public class Consents : EndpointBase
    {
        public Consents(Api api) : base(api)
        {
        }

        public void List(Action<ApiResponse<DataModel.ConsentAndGroupList>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/consents");
            this.client.DoGetRequest<DataModel.ConsentAndGroupList>(uriBuilder.Uri, callback);
        }
    }
}
#endif