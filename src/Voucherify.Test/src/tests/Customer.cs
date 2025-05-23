using System;
using System.Threading.Tasks;
using FluentAssertions;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;
using Xunit;
using Xunit.Abstractions;
using Xunit.Extensions.Ordering;

namespace Voucherify.Test
{
    [Collection("RequiresClientCredentials")]
    public class CustomerTest
    {
        private readonly CustomerFlow _customerFlow;
        private readonly int _delayMilliseconds = 2000;

        public CustomerTest()
        {
            _customerFlow = new CustomerFlow();
        }

        [SkippableFact]
        public async Task CreateAndDeleteCustomer()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var createdCustomer = await _customerFlow.createCustomer();

            createdCustomer.Should().NotBeNull();
            createdCustomer.Id.Should().NotBeNull();

            await Task.Delay(_delayMilliseconds);

            var deletedCustomer = await _customerFlow.deleteCustomer(createdCustomer.Id);
            deletedCustomer.Should().NotBeNull();
            deletedCustomer.RelatedObjectId.Should().Be(createdCustomer.Id);

            await Task.Delay(_delayMilliseconds);

            var exception = await Record.ExceptionAsync(async () =>
                await _customerFlow.getCustomer(createdCustomer.Id));

            exception.Should().NotBeNull();
        }
    }
}