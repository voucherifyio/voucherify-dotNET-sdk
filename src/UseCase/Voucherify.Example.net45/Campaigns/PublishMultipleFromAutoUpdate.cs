using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Campaigns
{
    public class PublishMultipleFromAutoUpdate : IUseCase
    {
        public async Task Run(Voucherify.Api api)
        {
            try
            {
                var voucherPublish = await api.Distributions.CreatePublication(new DataModel.Contexts.VoucherPublish()
                {
                    Campaign = new DataModel.Contexts.VoucherPublish.VoucherPublishCampaign()
                    {
                        Name = "AutoUdape1",
                        Count = 3
                    },
                    Customer = new DataModel.Contexts.Customer()
                    {
                        Email = "test@test.com",
                        Name = "Test Test",
                        SourceId = "test@test.com"
                    },
                    Metadata = new Core.DataModel.Metadata(new Dictionary<string, object>() { { "key1", "value1" } })
                });

                Console.WriteLine("[Vouchers][PublishMultipleFromAutoUpdate] Published - Publication: {0}", voucherPublish);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[Campaigns][PublishMultipleFromAutoUpdate] Ok");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Campaigns][PublishMultipleFromAutoUpdate] SomethingWentWrong: {0}", e);
                Console.ResetColor();
            }
        }
    }
}
