﻿#if VOUCHERIFYSERVER && APIASYNC
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class Validations : EndpointBase
    {
        public Validations(Api api) : base(api)
        {
        }

        public async Task<DataModel.ValidationVoucher> ValidateVoucher(string code, DataModel.Contexts.Validation context)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/validate", UriBuilderExtension.EnsureEscapedDataString("code", code)));
            return await this.client.DoPostRequest<DataModel.ValidationVoucher, DataModel.Contexts.Validation>(uriBuilder.Uri, context).ConfigureAwait(false);
        }

        public async Task<DataModel.ValidationPromotions> ValidatePromotion(DataModel.Contexts.Validation context)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/promotions/validation");
            return await this.client.DoPostRequest<DataModel.ValidationPromotions, DataModel.Contexts.Validation>(uriBuilder.Uri, context).ConfigureAwait(false);
        }

        public async Task<DataModel.Validation> Validate(string code, DataModel.Contexts.Validation context)
        {
            UriBuilder uriBuilder = null;

            if (string.IsNullOrEmpty(code))
            {
                uriBuilder = this.client.GetUriBuilder("/promotions/validation");
            }
            else
            {
                uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/validate", UriBuilderExtension.EnsureEscapedDataString("code", code)));
            }

            return await this.client.DoPostRequest<DataModel.Validation, DataModel.Contexts.Validation>(uriBuilder.Uri, context).ConfigureAwait(false);
        }

        public async Task<DataModel.StackableValidation> Validate(DataModel.Contexts.StackableValidation context)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/validations");
            return await this.client.DoPostRequest<DataModel.StackableValidation, DataModel.Contexts.StackableValidation>(uriBuilder.Uri, context).ConfigureAwait(false);
        }
    }
}

#endif