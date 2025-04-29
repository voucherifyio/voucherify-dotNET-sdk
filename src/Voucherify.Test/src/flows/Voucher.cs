using System;
using System.Threading.Tasks;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Voucherify.Test
{
    public class VoucherFlow
    {
        private static VouchersApi _vouchersApi;

        public VoucherFlow()
        {
            _vouchersApi = new VouchersApi(TestConfiguration.GetClientConfiguration());
        }

        public async Task<VouchersGetResponseBody> GetVoucher(string code)
        {
            return await _vouchersApi.GetVoucherAsync(code);
        }

        public async Task<VouchersDisableResponseBody> DisableVoucher(string code)
        {
            return await _vouchersApi.DisableVoucherAsync(code);
        }

        public async Task<VouchersEnableResponseBody> EnableVoucher(string code)
        {
            return await _vouchersApi.EnableVoucherAsync(code);
        }

        public async Task<VouchersBalanceUpdateResponseBody> UpdateLoyaltyCardBalance(string code, string sourceId, int amount, string reason)
        {
            var balanceUpdateRequestBody = new VouchersBalanceUpdateRequestBody
            {
                SourceId = sourceId,
                Amount = amount,
                Reason = reason
            };

            return await _vouchersApi.UpdateVoucherBalanceAsync(code, balanceUpdateRequestBody);
        }
    }
} 