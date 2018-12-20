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
   
        public async Task<DataModel.BusinessValidationRule> Get(string validationRuleId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}", Uri.EscapeDataString(validationRuleId)));
            return await this.client.DoGetRequest<DataModel.BusinessValidationRule>(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.BusinessValidationRule> Create(DataModel.Contexts.BusinessValidationRuleCreate validationRule)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/validation-rules/");
            return await this.client.DoPostRequest<DataModel.BusinessValidationRule, DataModel.Contexts.BusinessValidationRuleCreate>(uriBuilder.Uri, validationRule).ConfigureAwait(false);
        }

        public async Task<DataModel.BusinessValidationRule> Update(string validationRuleId, DataModel.Contexts.BusinessValidationRuleUpdate validationRule)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}", Uri.EscapeDataString(validationRuleId)));
            return await this.client.DoPutRequest<DataModel.BusinessValidationRule, DataModel.Contexts.BusinessValidationRuleUpdate>(uriBuilder.Uri, validationRule).ConfigureAwait(false);
        }

        public async Task Delete(string validationRuleId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}", Uri.EscapeDataString(validationRuleId)));
            await this.client.DoDeleteRequest(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.BusinessValidationRuleAssignment> CreateAssignment(string validationRuleId, DataModel.Contexts.BusinessValidationRuleAssignmentCreate validationRule)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}/assignments", Uri.EscapeDataString(validationRuleId)));
            return await this.client.DoPostRequest<DataModel.BusinessValidationRuleAssignment, DataModel.Contexts.BusinessValidationRuleAssignmentCreate>(uriBuilder.Uri, validationRule).ConfigureAwait(false);
        }

        public async Task DeleteAssignment(string validationRuleId, string assignmentId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}/assignments/{1}", Uri.EscapeDataString(validationRuleId), Uri.EscapeDataString(assignmentId)));
            await this.client.DoDeleteRequest(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.BusinessValidationRuleList> List(DataModel.Queries.BusinessValidationRuleFilter filter)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/validation-rules/"), filter);
            return await this.client.DoGetRequest<DataModel.BusinessValidationRuleList>(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.BusinessValidationRuleAssignmentList> ListAssignments(string validationRuleId, DataModel.Queries.BusinessValidationRuleAssignmentFilter filter)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/validation-rules/{0}/assignments", Uri.EscapeDataString(validationRuleId))), filter);
            return await this.client.DoGetRequest<DataModel.BusinessValidationRuleAssignmentList>(uriBuilder.Uri).ConfigureAwait(false);
        }
    }
}
#endif