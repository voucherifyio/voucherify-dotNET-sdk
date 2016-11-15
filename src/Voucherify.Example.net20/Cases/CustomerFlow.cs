using System;
using System.Collections.Generic;
using System.Text;

namespace Voucherify.Example.net20.Cases
{
    public class CustomerFlow
    {
        public static void Run(Voucherify.Api api)
        {
            api.Customers.Create(
                new DataModel.Contexts.CustomerCreate()
                {
                    Email = "bandraszyk@gmail.com",
                    Metadata = new Core.DataModel.Metadata(new Dictionary<string, object>() {
                        { "key1", "value1" },
                        { "key2", "value2" }
                    }),
                    Description = "Test Description",
                    Name = "Bandro"
                },
                (responseCreate) =>
                {
                    if (responseCreate.Exception != null)
                    {
                        Console.WriteLine("[CustomerFlow] (Create) Exception: {0}", responseCreate.Exception);
                        return;
                    }

                    Console.WriteLine("[CustomerFlow] (Create) Result: {0}", responseCreate.Result);
                    api.Customers.Get(responseCreate.Result.Id, (responseGet) =>
                    {
                        if (responseCreate.Exception != null)
                        {
                            Console.WriteLine("[CustomerFlow] (Get) Exception: {0}", responseGet.Exception);
                            return;
                        }

                        Console.WriteLine("[CustomerFlow] (Get) Result: {0}", responseGet.Result);
                        api.Customers.Update(
                            responseCreate.Result.Id,
                            DataModel.Contexts.CustomerUpdate.FromCustomer(responseCreate.Result)
                                .WithDescription("Test Description Updated")
                                .WithName("Bandro Updated"),
                            (responseUpdate) => {
                                if (responseUpdate.Exception != null)
                                {
                                    Console.WriteLine("[CustomerFlow] (Update) Exception: {0}", responseUpdate.Exception);
                                    return;
                                }

                                Console.WriteLine("[CustomerFlow] (Update) Result: {0}", responseUpdate.Result);
                                api.Customers.Delete(responseUpdate.Result.Id, (responseDelete) =>
                                {
                                    if (responseDelete.Exception != null)
                                    {
                                        Console.WriteLine("[CustomerFlow] (Delete) Exception: {0}", responseDelete.Exception);
                                        return;
                                    }

                                    Console.WriteLine("[CustomerFlow] (Delete) Done");
                                });
                            });
                    });
                });
        }
    }
}
