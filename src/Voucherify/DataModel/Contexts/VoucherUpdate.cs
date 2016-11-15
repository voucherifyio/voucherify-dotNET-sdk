#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class VoucherUpdate
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

        private VoucherUpdate()
        {
            Metadata = new Metadata();
        }

        public static VoucherUpdate FromEmpty()
        {
            return new VoucherUpdate();
        }

        public static VoucherUpdate FromVoucher(Voucher voucher)
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
            
            return new VoucherUpdate()
            {
                AdditionalInfo = voucher.AdditionalInfo,
                Category = voucher.Category,
                ExpirationDate = voucher.ExpirationDate,
                StartDate = voucher.StartDate,
                Active = voucher.Active,
                Metadata = metadata
            };
        }

        public VoucherUpdate WithCategory(string category)
        {
            this.Category = category;
            return this;
        }

        public VoucherUpdate WithStartDate(DateTime? startDate)
        {
            this.StartDate = startDate;
            return this;
        }

        public VoucherUpdate WithExpirationDate(DateTime? expirationDate)
        {
            this.ExpirationDate = expirationDate;
            return this;
        }

        public VoucherUpdate WithActive(bool active)
        {
            this.Active = active;
            return this;
        }

        public VoucherUpdate WithAdditionalInfo(string additionalInfo)
        {
            this.AdditionalInfo = additionalInfo;
            return this;
        }

        public VoucherUpdate WithMetadata(Metadata metadata)
        {
            this.Metadata = metadata;
            return this;
        }
    }
}
#endif