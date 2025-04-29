using System;
using System.Threading.Tasks;
using System.Collections.Generic;
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
    public class ProductsTest
    {
        private readonly ProductsFlow _productsFlow;
        private readonly int _delayMilliseconds = 2000;

        public ProductsTest()
        {
            _productsFlow = new ProductsFlow();
        }

        [SkippableFact]
        public async Task CreateAndGetProduct()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var createdProduct = await _productsFlow.createProduct(20000);
            createdProduct.Should().NotBeNull();
            createdProduct.SourceId.Should().NotBeNull();

            await Task.Delay(_delayMilliseconds);

            var product = await _productsFlow.getProduct(createdProduct.SourceId);
            product.Should().NotBeNull();
            product.SourceId.Should().Be(createdProduct.SourceId);

            await _productsFlow.deleteProduct(createdProduct.SourceId);
        }

        [SkippableFact]
        public async Task UpdateProduct()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var createdProduct = await _productsFlow.createProduct(20000);
            createdProduct.Should().NotBeNull();

            await Task.Delay(_delayMilliseconds);

            var updatedProduct = await _productsFlow.updateProduct(createdProduct.SourceId, 55000);
            updatedProduct.Should().NotBeNull();
            updatedProduct.Price.Should().Be(55000);

            await _productsFlow.deleteProduct(createdProduct.SourceId);
        }

        [SkippableFact]
        public async Task ListProducts()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var product1 = await _productsFlow.createProduct(20000);
            var product2 = await _productsFlow.createProduct(60000);

            await Task.Delay(_delayMilliseconds);

            var products = await _productsFlow.listProducts();
            products.Should().NotBeNull();
            products.Products.Should().NotBeEmpty();

            await _productsFlow.deleteProduct(product1.SourceId);
            await _productsFlow.deleteProduct(product2.SourceId);
        }

        [SkippableFact]
        public async Task UpdateProductsInBulk()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var asyncAction = await _productsFlow.updateProductInBulk();
            asyncAction.Should().NotBeNull();
        }

        [SkippableFact]
        public async Task UpdateMetadataInBulk()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var product1 = await _productsFlow.createProduct(20000);
            var product2 = await _productsFlow.createProduct(60000);
            var productIds = new List<string> { product1.SourceId, product2.SourceId };

            await Task.Delay(_delayMilliseconds);

            var asyncAction = await _productsFlow.updateProductMetadataInBulk(productIds);
            asyncAction.Should().NotBeNull();

            await _productsFlow.deleteProduct(product1.SourceId);
            await _productsFlow.deleteProduct(product2.SourceId);
        }

        [SkippableFact]
        public async Task CreateAndUpdateSku()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var product = await _productsFlow.createProduct(20000);
            product.Should().NotBeNull();

            await Task.Delay(_delayMilliseconds);

            var sku = await _productsFlow.createSku(product.SourceId, 5000);
            sku.Should().NotBeNull();
            sku.SourceId.Should().NotBeNull();

            await Task.Delay(_delayMilliseconds);

            var updatedSku = await _productsFlow.updateSku(product.SourceId, sku.SourceId, 2000);
            updatedSku.Should().NotBeNull();
            updatedSku.Price.Should().Be(2000);

            await _productsFlow.deleteSku(product.SourceId, sku.SourceId);
            await _productsFlow.deleteProduct(product.SourceId);
        }

        [SkippableFact]
        public async Task GetAndListSkus()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var product = await _productsFlow.createProduct(20000);
            var sku = await _productsFlow.createSku(product.SourceId, 5000);

            await Task.Delay(_delayMilliseconds);

            var retrievedSku = await _productsFlow.getSku(sku.SourceId);
            retrievedSku.Should().NotBeNull();
            retrievedSku.SourceId.Should().Be(sku.SourceId);

            var skus = await _productsFlow.listSkusInProduct(product.SourceId);
            skus.Should().NotBeNull();
            skus.Skus.Should().NotBeEmpty();

            await _productsFlow.deleteSku(product.SourceId, sku.SourceId);
            await _productsFlow.deleteProduct(product.SourceId);
        }

        [SkippableFact]
        public async Task DeleteProduct()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var product = await _productsFlow.createProduct(20000);
            product.Should().NotBeNull();

            await Task.Delay(_delayMilliseconds);

            await _productsFlow.deleteProduct(product.SourceId);

            await Task.Delay(_delayMilliseconds);

            var exception = await Record.ExceptionAsync(async () =>
                await _productsFlow.getProduct(product.SourceId));
            
            exception.Should().NotBeNull();
        }

        [SkippableFact]
        public async Task DeleteSku()
        {
            Skip.If(!TestConfiguration.HasClientCredentials, "Client credentials not provided");

            var product = await _productsFlow.createProduct(20000);
            var sku = await _productsFlow.createSku(product.SourceId, 5000);

            await Task.Delay(_delayMilliseconds);

            await _productsFlow.deleteSku(product.SourceId, sku.SourceId);

            await Task.Delay(_delayMilliseconds);

            var exception = await Record.ExceptionAsync(async () =>
                await _productsFlow.getSku(sku.SourceId));
            
            exception.Should().NotBeNull();

            await _productsFlow.deleteProduct(product.SourceId);
        }
    }
} 