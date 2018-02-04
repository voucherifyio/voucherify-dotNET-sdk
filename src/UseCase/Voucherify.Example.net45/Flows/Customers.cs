using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Flows
{
    public class Customers : IUseCase
    {
        public async Task Run(Voucherify.Api api)
        {
            try
            {
                DataModel.Customer customerCreated = await api.Customers.Create(
                    new DataModel.Contexts.CustomerCreate()
                    {
                        Email = "bandraszyk@gmail.com",
                        Metadata = new Core.DataModel.Metadata(new Dictionary<string, object>() {
                            { "key1", "value1" },
                            { "key2", "value2" }
                        }),
                        Description = "Test Description",
                        Name = "Bandro"
                    });
                Console.WriteLine("[Flows][Customers] Created - Customer: {0}", customerCreated);

                DataModel.Customer customerGet = await api.Customers.Get(customerCreated.Id);
                Console.WriteLine("[Flows][Customers] Retrieved - Customer: {0}", customerGet);

                DataModel.Customer customerUpdate = await api.Customers.Update(
                                   customerGet.Id,
                                   DataModel.Contexts.CustomerUpdate.FromCustomer(customerGet).WithName("Bandro Updated"));
                Console.WriteLine("[Flows][Customers] Updated - Customer: {0}", customerUpdate);

                await api.Customers.Delete(customerUpdate.Id);
                Console.WriteLine("[Flows][Customers] Deleted");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[Flows][Customers] Ok");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Flows][Customers] SomethingWentWrong: {0}", e);
                Console.ResetColor();
            }
        }
    }
}
