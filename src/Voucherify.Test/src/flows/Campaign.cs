using System;
using System.IO;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;
using System.Threading.Tasks;

namespace Voucherify.Test
{
    public class CampaignFlow
    {
        private static CampaignsApi _campaignsApi;
        private static VouchersApi _vouchersApi;
        private static PublicationsApi _publicationsApi;

        public CampaignFlow()
        {
            _campaignsApi = new CampaignsApi(TestConfiguration.GetClientConfiguration());
            _vouchersApi = new VouchersApi(TestConfiguration.GetClientConfiguration());
            _publicationsApi = new PublicationsApi(TestConfiguration.GetClientConfiguration());
        }

        public async Task<CampaignsCreateResponseBody> createDiscountCampaign(String name, int vouchersCount = 3)
        {
            var campaignsCreateRequestBody = new CampaignsCreateRequestBody(
                name: name,
                type: CampaignsCreateRequestBody.TypeEnum.AUTOUPDATE,
                voucher: new CampaignsCreateRequestBodyVoucher(
                    type: CampaignsCreateRequestBodyVoucher.TypeEnum.DISCOUNTVOUCHER,
                    discount: new Discount(
                        type: Discount.TypeEnum.AMOUNT,
                        amountOff: 15
                    ),
                    redemption: new CampaignsCreateRequestBodyVoucherRedemption(
                        quantity: 10
                    )
                ),
                vouchersCount: vouchersCount
            );

            return await _campaignsApi.CreateCampaignAsync(campaignsCreateRequestBody);
        }

        public async Task<CampaignsCreateResponseBody> createLoyaltyCampaign(String name, int points = 1000, int vouchersCount = 1)
        {
            var campaignsCreateRequestBody = new CampaignsCreateRequestBody(
                name: name,
                type: CampaignsCreateRequestBody.TypeEnum.AUTOUPDATE,
                campaignType: CampaignsCreateRequestBody.CampaignTypeEnum.LOYALTYPROGRAM,
                voucher: new CampaignsCreateRequestBodyVoucher(
                    type: CampaignsCreateRequestBodyVoucher.TypeEnum.LOYALTYCARD,
                    loyaltyCard: new CampaignLoyaltyCard(
                        points: points
                    )
                ),
                vouchersCount: vouchersCount
            );

            return await _campaignsApi.CreateCampaignAsync(campaignsCreateRequestBody);
        }

        public async Task<VouchersListResponseBody> getCampaignVouchers(string campaignId)
        {
            return await _vouchersApi.ListVouchersAsync(10, 1, null, campaignId);
        }

        public async Task<PublicationsCreateResponseBody> createPublication(Customer customer, string voucherCode)
        {
            var publicationsCreateRequestBody = new PublicationsCreateRequestBody
            {
                Customer = customer,
                Voucher = voucherCode
            };

            return await _publicationsApi.CreatePublicationAsync(publicationsCreateRequestBody: publicationsCreateRequestBody);
        }

        public async Task<CampaignsVouchersCreateCombinedResponseBody> addVoucherToCampaign(string campaignId)
        {
            return await _campaignsApi.AddVouchersToCampaignAsync(campaignId, 1);
        }

        public async Task<CampaignsVouchersCreateCombinedResponseBody> createBundleOfVouchers(string campaignId, int vouchersCount = 5)
        {
            return await _campaignsApi.AddVouchersToCampaignAsync(campaignId, vouchersCount);
        }
    }
}