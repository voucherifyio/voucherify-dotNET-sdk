using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Voucherify.Test
{
    public class PublicationFlow
    {
        private readonly CampaignFlow _campaignFlow;
        private readonly CustomerFlow _customerFlow;
        private readonly PublicationsApi _publicationsApi;
        private readonly int _delayMilliseconds = 2000;

        public PublicationFlow()
        {
            var configuration = TestConfiguration.GetClientConfiguration();
            _campaignFlow = new CampaignFlow();
            _customerFlow = new CustomerFlow();
            _publicationsApi = new PublicationsApi(configuration);
        }

        public async Task<(CampaignsCreateResponseBody Campaign, List<VoucherWithCategories> Vouchers, CustomersCreateResponseBody Customer)> createAndPublishVoucherForCustomer(
            string campaignName,
            int vouchersCount = 2)
        {
            var campaign = await _campaignFlow.createDiscountCampaign(campaignName, vouchersCount);

            await Task.Delay(_delayMilliseconds);

            var vouchers = await _campaignFlow.getCampaignVouchers(campaign.Id);
            var customer = await _customerFlow.createCustomer();

            var publications = new List<PublicationsCreateResponseBody>();
            foreach (var voucher in vouchers.Vouchers)
            {
                var publication = await createPublication(customer.Id, voucher.Code);
                publications.Add(publication);
                await Task.Delay(_delayMilliseconds);
            }

            return (campaign, vouchers.Vouchers, customer);
        }

        public async Task<PublicationsCreateResponseBody> createPublication(string customerId, string voucherCode)
        {
            var publicationsCreateRequestBody = new PublicationsCreateRequestBody
            {
                Customer = new Customer(customerId),
                Voucher = voucherCode
            };

            return await _publicationsApi.CreatePublicationAsync(publicationsCreateRequestBody: publicationsCreateRequestBody);
        }
    }
} 