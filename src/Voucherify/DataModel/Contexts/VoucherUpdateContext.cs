#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class VoucherUpdateContext
    {
        [JsonProperty(PropertyName = "category")]
        public string Category { get; private set; }

        [JsonProperty(PropertyName = "start_date")]
        public DateTime? StartDate { get; private set; }

        [JsonProperty(PropertyName = "expiration_date")]
        public DateTime? ExpirationDate { get; private set; }

        [JsonProperty(PropertyName = "active")]
        public bool Active { get; private set; }

        [JsonProperty(PropertyName = "additional_info")]
        public string AdditionalInfo { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        private VoucherUpdateContext()
        {
            Metadata = new Metadata();
        }

        public static VoucherUpdateContext FromEmpty()
        {
            return new VoucherUpdateContext();
        }

        public static VoucherUpdateContext FromVoucher(Voucher voucher)
        {
            Metadata metadata = null;

            if (voucher.Metadata != null)
            {
                metadata = new Metadata();

                foreach (var key in voucher.Metadata.Keys)
                {
                    metadata.Add(key, voucher.Metadata[key]);
                }
            }
            
            return new VoucherUpdateContext()
            {
                AdditionalInfo = voucher.AdditionalInfo,
                Category = voucher.Category,
                ExpirationDate = voucher.ExpirationDate,
                StartDate = voucher.StartDate,
                Active = voucher.Active,
                Metadata = metadata
            };
        }

        public VoucherUpdateContext WithCategory(string category)
        {
            this.Category = category;
            return this;
        }

        public VoucherUpdateContext WithStartDate(DateTime? startDate)
        {
            this.StartDate = startDate;
            return this;
        }

        public VoucherUpdateContext WithExpirationDate(DateTime? expirationDate)
        {
            this.ExpirationDate = expirationDate;
            return this;
        }

        public VoucherUpdateContext WithActive(bool active)
        {
            this.Active = active;
            return this;
        }

        public VoucherUpdateContext WithAdditionalInfo(string additionalInfo)
        {
            this.AdditionalInfo = additionalInfo;
            return this;
        }

        public VoucherUpdateContext WithMetadata(Metadata metadata)
        {
            this.Metadata = metadata;
            return this;
        }
    }
}
#endif