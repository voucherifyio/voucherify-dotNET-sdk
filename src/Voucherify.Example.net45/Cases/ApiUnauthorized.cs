using System;
using System.Threading.Tasks;

namespace Voucherify.Example.net45.Cases
{
    public class ApiUnauthorized
    {
        public static async Task Run()
        {
            try
            { 
                var serverApi = new Voucherify.Api("<invalid-app>", "<invalid-token>");
                var result = await serverApi.Validations.ValidateVoucher("<invalid_code>", new DataModel.Contexts.VoucherValidation());
                Console.WriteLine("[ApiUnauthorized] Result: {0}", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("[ApiUnauthorized] Exception: {0}", e);
            }
        }
    }
}
