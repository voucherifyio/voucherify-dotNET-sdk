using System;
using System.Threading.Tasks;
using FluentAssertions;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;
using Xunit;
using Xunit.Extensions.Ordering;
using Xunit.Abstractions;

namespace Voucherify.Test
{
    [TestCaseOrderer("Xunit.Extensions.Ordering.TestCaseOrderer", "Xunit.Extensions.Ordering")]
    [Collection("RequiresClientCredentials")]
    public class OrdersTest
    {
        private readonly OrdersFlow _ordersFlow;
        private readonly int _delayMilliseconds = 2000;

        public OrdersTest()
        {
            _ordersFlow = new OrdersFlow();
        }

        [SkippableFact, Order(1)]
        public async Task CreateOrder()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var createdOrder = await _ordersFlow.createOrder();

            createdOrder.Should().NotBeNull();
            createdOrder.Id.Should().NotBeNull();
            createdOrder.Status.Should().Be(OrdersCreateResponseBody.StatusEnum.CREATED);

            await Task.Delay(_delayMilliseconds);

            var order = await _ordersFlow.getOrder(createdOrder.Id);
            order.Should().NotBeNull();
            order.Id.Should().Be(createdOrder.Id);
            order.Status.Should().Be(OrdersGetResponseBody.StatusEnum.CREATED);
        }

        [SkippableFact, Order(2)]
        public async Task UpdateOrder()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var createdOrder = await _ordersFlow.createOrder();
            createdOrder.Should().NotBeNull();
            createdOrder.Id.Should().NotBeNull();

            await Task.Delay(_delayMilliseconds);

            var updatedOrder = await _ordersFlow.updateOrder(createdOrder.Id);
            updatedOrder.Should().NotBeNull();
            updatedOrder.Id.Should().Be(createdOrder.Id);
            updatedOrder.Status.Should().Be(OrdersUpdateResponseBody.StatusEnum.PAID);
        }

        [SkippableFact, Order(3)]
        public async Task ListOrders()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var orders = await _ordersFlow.listOrders();
            orders.Should().NotBeNull();
            orders.Orders.Should().NotBeNull();
            orders.Orders.Count.Should().BeLessThanOrEqualTo(10);
            orders.Orders.Count.Should().BeGreaterThanOrEqualTo(1);
        }
    }
}
