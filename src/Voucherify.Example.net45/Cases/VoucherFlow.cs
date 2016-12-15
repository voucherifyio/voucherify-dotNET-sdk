using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Cases
{
    public class VoucherFlow
    {
        public async static Task Run(Voucherify.Api api)
        {
            try
            {
                var voucherCreate = await api.Vouchers.Create(new DataModel.Contexts.VoucherCreate()
                {
                    Active = true,
                    Category = "TEST-SDK-Category",
                    AdditionalInfo = "TEST-AdditionalInfo",
                    StartDate = DateTime.Now.AddDays(-1),
                    ExpirationDate = DateTime.Now.AddDays(10),
                    Redemption = new DataModel.Contexts.VoucherRedemption().WithQuantity(1),
                    Metadata = new Core.DataModel.Metadata(new Dictionary<string, object>() {
                        { "key1", "value1" },
                        { "key2", "value2" }
                    })
                }.WithDiscount(new DataModel.Discount().WithPercentOff(67)));
                Console.WriteLine("[VoucherFlow] (Create) Result: {0}", voucherCreate);
                var voucherGet = await api.Vouchers.Get(voucherCreate.Code);
                Console.WriteLine("[VoucherFlow] (Get) Result: {0}", voucherGet);
                var voucherUpdate = await api.Vouchers.Update(
                    voucherGet.Code,
                    DataModel.Contexts.VoucherUpdate.FromVoucher(voucherGet)
                        .WithAdditionalInfo("Some Additional Text"));
                Console.WriteLine("[VoucherFlow] (Update) Result: {0}", voucherUpdate);
                var voucherValidate = await api.Validations.ValidateVoucher(voucherGet.Code,
                    new DataModel.Contexts.VoucherValidation()
                    {
                        TrackingId = "Sample Tracking Id"
                    });
                Console.WriteLine("[VoucherFlow] (Validate) Result: {0}", voucherValidate);
                await api.Vouchers.Disable(voucherGet.Code);
                Console.WriteLine("[VoucherFlow] (Disable) Done");
                await api.Vouchers.Enable(voucherGet.Code);
                Console.WriteLine("[VoucherFlow] (Enable) Done");
                await api.Vouchers.Delete(
                    voucherGet.Code,
                    new DataModel.Queries.VoucherDelete() { Force = true });
                Console.WriteLine("[VoucherFlow] (Delete) Done");
            }
            catch (Exception e)
            {
                Console.WriteLine("[VoucherFlow] Exception: {0}", e);
            }
        }
    }
}
