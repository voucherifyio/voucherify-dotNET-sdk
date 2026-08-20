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
        private static AsyncActionsApi _asyncActionsApi;

        public CampaignFlow()
        {
            _campaignsApi = new CampaignsApi(TestConfiguration.GetClientConfiguration());
            _vouchersApi = new VouchersApi(TestConfiguration.GetClientConfiguration());
            _publicationsApi = new PublicationsApi(TestConfiguration.GetClientConfiguration());
            _asyncActionsApi = new AsyncActionsApi(TestConfiguration.GetClientConfiguration());
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
            return await _vouchersApi.ListVouchersAsync(limit: 100, page: 1, campaignId: campaignId);
        }

        public async Task<VouchersListResponseBody> waitForCampaignVouchers(
            string campaignId,
            int expectedCount,
            int maxAttempts = 15,
            int delayMs = 1000)
        {
            VouchersListResponseBody result = null;

            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                result = await getCampaignVouchers(campaignId);
                int count = result?.Vouchers?.Count ?? 0;
                if (count >= expectedCount)
                {
                    return result;
                }

                await Task.Delay(delayMs);
            }

            throw new InvalidOperationException(
                $"Timed out waiting for {expectedCount} vouchers on campaign {campaignId}. " +
                $"Last count: {result?.Vouchers?.Count ?? 0}.");
        }

        public async Task waitForAsyncAction(string asyncActionId, int maxAttempts = 15, int delayMs = 1000)
        {
            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                await Task.Delay(delayMs);

                var action = await _asyncActionsApi.GetAsyncActionAsync(asyncActionId);
                if (action.OperationStatus == AsyncActionGetResponseBody.OperationStatusEnum.SUCCESS)
                {
                    return;
                }

                if (action.OperationStatus == AsyncActionGetResponseBody.OperationStatusEnum.FAILED)
                {
                    throw new InvalidOperationException($"Async action {asyncActionId} failed.");
                }
            }

            throw new InvalidOperationException(
                $"Async action {asyncActionId} did not complete after {maxAttempts} attempts.");
        }

        public async Task<CampaignsVouchersCreateCombinedResponseBody> addVoucherToCampaign(string campaignId)
        {
            return await _campaignsApi.AddVouchersToCampaignAsync(campaignId, new CampaignsVouchersCreateInBulkRequestBody(), 1);
        }

        public async Task<CampaignsVouchersCreateCombinedResponseBody> createBundleOfVouchers(string campaignId, int vouchersCount = 5)
        {
            return await _campaignsApi.AddVouchersToCampaignAsync(campaignId, new CampaignsVouchersCreateInBulkRequestBody(), vouchersCount);
        }
    }
}
