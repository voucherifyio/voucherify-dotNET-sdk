using System;
using System.Threading.Tasks;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Voucherify.Test
{
    public class OrdersFlow
    {
        private readonly OrdersApi _ordersApi;

        public OrdersFlow()
        {
            _ordersApi = new OrdersApi(TestConfiguration.GetClientConfiguration());
        }

        public async Task<OrdersCreateResponseBody> createOrder()
        {
            var ordersCreateRequestBody = new OrdersCreateRequestBody
            {
                Status = OrdersCreateRequestBody.StatusEnum.CREATED,
                Amount = 10000,
                Items = new System.Collections.Generic.List<OrderItem>
                {
                    new OrderItem
                    {
                        ProductId = "prod_test",
                        Quantity = 1,
                        Price = 10000
                    }
                }
            };

            return await _ordersApi.CreateOrderAsync(ordersCreateRequestBody);
        }

        public async Task<OrdersGetResponseBody> getOrder(string orderId)
        {
            return await _ordersApi.GetOrderAsync(orderId);
        }

        public async Task<OrdersUpdateResponseBody> updateOrder(string orderId)
        {
            var ordersUpdateRequestBody = new OrdersUpdateRequestBody
            {
                Status = OrdersUpdateRequestBody.StatusEnum.PAID
            };

            return await _ordersApi.UpdateOrderAsync(orderId, ordersUpdateRequestBody);
        }

        public async Task<OrdersListResponseBody> listOrders()
        {
            return await _ordersApi.ListOrdersAsync(limit: 10);
        }
    }
} 