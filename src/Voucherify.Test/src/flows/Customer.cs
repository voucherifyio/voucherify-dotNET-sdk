using System;
using System.Threading.Tasks;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Voucherify.Test
{
    public class CustomerFlow
    {
        private readonly CustomersApi _customersApi;

        public CustomerFlow()
        {
            _customersApi = new CustomersApi(TestConfiguration.GetClientConfiguration());
        }

        public async Task<CustomersCreateResponseBody> createCustomer(string name, string email)
        {
            var customersCreateRequestBody = new CustomersCreateRequestBody
            {
                Name = name,
                Email = email
            };

            return await _customersApi.CreateCustomerAsync(customersCreateRequestBody);
        }

        public async Task<CustomersGetResponseBody> getCustomer(string customerId)
        {
            return await _customersApi.GetCustomerAsync(customerId);
        }

        public async Task<CustomersPermanentDeletionCreateResponseBody> deleteCustomer(string customerId)
        {
            return await _customersApi.CustomerPermanentlyDeletionAsync(customerId);
        }
    }
}
