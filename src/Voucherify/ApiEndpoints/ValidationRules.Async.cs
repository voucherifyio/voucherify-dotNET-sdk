#if VOUCHERIFYSERVER && APIASYNC
using System;
using System.Threading.Tasks;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class ValidationRules : EndpointBase
    {
        public ValidationRules(Api api) : base(api)
        {
        }

        public async Task<DataModel.ValidationRule> Get(string validationRuleId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}", Uri.EscapeDataString(validationRuleId)));
            return await this.client.DoGetRequest<DataModel.ValidationRule>(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.ValidationRule> Create(DataModel.Contexts.ValidationRuleCreate validationRule)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/validation-rules/");
            return await this.client.DoPostRequest<DataModel.ValidationRule, DataModel.Contexts.ValidationRuleCreate>(uriBuilder.Uri, validationRule).ConfigureAwait(false);
        }

        public async Task<DataModel.ValidationRule> Update(string validationRuleId, DataModel.Contexts.ValidationRuleUpdate validationRule)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}", Uri.EscapeDataString(validationRuleId)));
            return await this.client.DoPutRequest<DataModel.ValidationRule, DataModel.Contexts.ValidationRuleUpdate>(uriBuilder.Uri, validationRule).ConfigureAwait(false);
        }

        public async Task Delete(string validationRuleId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}", Uri.EscapeDataString(validationRuleId)));
            await this.client.DoDeleteRequest(uriBuilder.Uri).ConfigureAwait(false);
        }
    }
}
#endif