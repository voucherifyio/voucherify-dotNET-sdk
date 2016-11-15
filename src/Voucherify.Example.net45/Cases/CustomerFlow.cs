using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Cases
{
    public class CustomerFlow
    {
        public async static Task Run(Voucherify.Api api)
        {
            try
            {
                DataModel.Customer createdCustomer = await api.Customers.Create(
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
                Console.WriteLine("[CustomerFlow] (Create) Result: {0}", createdCustomer);
                DataModel.Customer getCustomer = await api.Customers.Get(createdCustomer.Id);
                Console.WriteLine("[CustomerFlow] (Get) Result: {0}", getCustomer);
                DataModel.Customer updatedCustomer = await api.Customers.Update(
                                   getCustomer.Id,
                                   DataModel.Contexts.CustomerUpdate.FromCustomer(getCustomer)
                                       .WithDescription("Test Description Updated")
                                       .WithName("Bandro Updated"));
                Console.WriteLine("[CustomerFlow] (Update) Result: {0}", updatedCustomer);
                await api.Customers.Delete(updatedCustomer.Id);
                Console.WriteLine("[CustomerFlow] (Delete) Done");
            }
            catch (Exception e)
            {
                Console.WriteLine("[CustomerFlow] Exception: {0}", e);
            }
        }
    }
}
