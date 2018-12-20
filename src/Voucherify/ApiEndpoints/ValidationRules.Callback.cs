#if VOUCHERIFYSERVER && !APIASYNC
using System;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class ValidationRules : EndpointBase
    {
        public ValidationRules(Api api) : base(api)
        {
        }

        public void Get(string validationRuleId, Action<ApiResponse<DataModel.BusinessValidationRule>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}", Uri.EscapeDataString(validationRuleId)));
            this.client.DoGetRequest<DataModel.BusinessValidationRule>(uriBuilder.Uri, callback);
        }

        public void Create(DataModel.Contexts.BusinessValidationRuleCreate validationRule, Action<ApiResponse<DataModel.BusinessValidationRule>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/validation-rules/");
            this.client.DoPostRequest(uriBuilder.Uri, validationRule, callback);
        }

        public void Update(string validationRuleId, DataModel.Contexts.BusinessValidationRuleUpdate validationRule, Action<ApiResponse<DataModel.BusinessValidationRule>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}", Uri.EscapeDataString(validationRuleId)));
            this.client.DoPutRequest(uriBuilder.Uri, validationRule, callback);
        }

        public void Delete(string validationRuleId, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}", Uri.EscapeDataString(validationRuleId)));
            this.client.DoDeleteRequest(uriBuilder.Uri, callback);
        }

        public void CreateAssignment(string validationRuleId, DataModel.Contexts.BusinessValidationRuleAssignmentCreate validationRule, Action<ApiResponse<DataModel.BusinessValidationRuleAssignment>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}/assignments", Uri.EscapeDataString(validationRuleId)));
            this.client.DoPostRequest(uriBuilder.Uri, validationRule, callback);
        }

        public void DeleteAssignment(string validationRuleId, string assignmentId, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}/assignments/{1}", Uri.EscapeDataString(validationRuleId), Uri.EscapeDataString(assignmentId)));
             this.client.DoDeleteRequest(uriBuilder.Uri, callback);
        }

        public void List(DataModel.Queries.BusinessValidationRuleFilter filter, Action<ApiResponse<DataModel.BusinessValidationRuleList>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/validation-rules/"), filter);
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void ListAssignments(string validationRuleId, DataModel.Queries.BusinessValidationRuleAssignmentFilter filter, Action<ApiResponse<DataModel.BusinessValidationRuleAssignmentList>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/validation-rules/{0}/assignments", Uri.EscapeDataString(validationRuleId))), filter);
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }
    }
}
#endif