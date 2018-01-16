using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Cases
{
    public class GiftCards
    {
        public async static Task Run(Voucherify.Api api, String voucherCode, int amount)
        {
            try
            {
                var voucherCreate = await api.Vouchers.Create(new DataModel.Contexts.VoucherCreate()
                {
                    Active = true,
                    Category = "TEST-SDK-Category",
                    AdditionalInfo = "TEST-AdditionalInfo",
                    StartDate = DateTime.Now.AddDays(-1),
                    CodeConfig = new DataModel.CodeConfig().WithPatter(voucherCode),
                    ExpirationDate = DateTime.Now.AddDays(10),
                    Metadata = new Core.DataModel.Metadata(new Dictionary<string, object>() {
                        { "key1", "value1" },
                        { "key2", "value2" }
                    })
                }.WithGift(new DataModel.Contexts.GiftCreate().WithAmount(amount * 5)));
                Console.WriteLine("[GiftCard] (Create) Result: {0}", voucherCreate);
                var voucherGet = await api.Vouchers.Get(voucherCreate.Code);
                Console.WriteLine("[VoucherFlow] (Get) Result: {0}", voucherGet);
                var voucherUpdate = await api.Vouchers.Update(
                    voucherGet.Code,
                    DataModel.Contexts.VoucherUpdate.FromVoucher(voucherGet)
                        .WithAdditionalInfo("Some Additional Text"));
                Console.WriteLine("[GiftCard] (Update) Result: {0}", voucherUpdate);
                var voucherValidate = await api.Validations.ValidateVoucher(voucherGet.Code,
                    new DataModel.Contexts.VoucherValidation()
                    {
                        TrackingId = "Sample Tracking Id",
                        Order = new DataModel.Order().WithAmount(amount)
                    });
                Console.WriteLine("[GiftCard] (Validate) Result: {0}", voucherValidate);
                var redemptionRedeem = await api.Redemptions.Redeem(
                    voucherCreate.Code,
                    new DataModel.Queries.RedemptionRedeem(),
                    new DataModel.Contexts.RedemptionRedeem() {
                        Order = new DataModel.Order().WithAmount(amount)
                    }.WithCustomerId("test@customer.com"));
                Console.WriteLine("[VoucherFlow] (Redeem) Result: {0}", redemptionRedeem);
                voucherGet = await api.Vouchers.Get(voucherCreate.Code);
                Console.WriteLine("[VoucherFlow] (Get) Result: {0}", voucherGet);
            }
            catch (Exception e)
            {
                Console.WriteLine("[VoucherFlow] Exception: {0}", e);
            }
        }
    }
}
