namespace Pharmacy.Tests.Services.Shop
{
    using Xunit;
    using FluentAssertions;
    using Pharmacy.Models;
    using System.Collections.Generic;
    using Pharmacy.Services.Shop.Implementations;
    using System.Linq;

    public class ProductsServiceTests : BaseTest
    {
        public ProductsServiceTests()
        {
            Test.Initialize();
        }

        [Fact]
        public void AllShouldReturnAllProductsOrderedAphabeticly()
        {
            var service = this.GetProductsServicewithData();
            service.All(1).Should().HaveCount(2).And.Match(p => p.ElementAt(0).ProductId == 2);
        }

        [Fact]
        public void AllOnSecondPageProductsCollectionShouldBeEmpty()
        {
            var service = this.GetProductsServicewithData();
            service.All(2).Should().HaveCount(0);
        }

        [Fact]
        public void ByCategoryWithWrongIdShouldReturnEmptyCollection()
        {
            var service = this.GetProductsServicewithData();
            service.ByCategory(100, 1).Should().HaveCount(0);
        }

        [Fact]
        public void ByCategoryWithCorrectIdShouldReturnAllProductsOfTheCategoryOrderedAphabeticly()
        {
            var service = this.GetProductsServicewithData();
            service.ByCategory(1, 1).Should().HaveCount(2).And.Match(p => p.ElementAt(0).ProductId == 2);
        }

        [Fact]
        public void ByCategoryWithCorrectIdShouldnotHaveAnyProductOnSecondPage()
        {
            var service = this.GetProductsServicewithData();
            service.ByCategory(1, 2).Should().HaveCount(0);
        }

        [Fact]
        public void ByIdWithWrongIdShouldReturnNull()
        {
            var service = this.GetProductsServicewithData();
            service.ById(10).Should().BeNull();
        }

        [Fact]
        public void ByIdWithCorrectIdShouldReturnProduct()
        {
            var service = this.GetProductsServicewithData();
            var product = service.ById(1);
            product.Should().NotBeNull();
            product.ProductId.Should().Be(1);
        }

        [Fact]
        public void NumOfProductsshouldReturnProductsCount()
        {
            var service = this.GetProductsServicewithData();
            service.NumOfProducts().Should().Be(2);
        }

        [Fact]
        public void NumOfProductsInCategory()
        {
            var service = this.GetProductsServicewithData();
            service.NumOfProductsInCategory(1).Should().Be(2);
        }

        [Fact]
        public void GetProductsDropDownShouldReturnAllProductsOrderedAlphabeticly()
        {
            var service = this.GetProductsServicewithData();
            service.GetProductsDropDown().Should().HaveCount(2).And.Match(p => p.ElementAt(0).Id == 2);
        }

        [Fact]
        public void GetProductInfoForCartByIdWithCorrectIdShouldReturnProduct()
        {
            var service = this.GetProductsServicewithData();
            var product = service.GetProductInfoForCartById(1);
            product.Should().NotBeNull();
            product.ProductId.Should().Be(1);
        }

        [Fact]
        public void GetProductInfoForCartByIdWithWrongIdShouldReturnProduct()
        {
            var service = this.GetProductsServicewithData();
            service.GetProductInfoForCartById(100).Should().BeNull();
        }

        private ProductsService GetProductsServicewithData()
        {
            var db = this.InitializeDb();
            db.Categories.Add(new Category { Id = 1, Name = "TestCategory" });
            db.Products.Add(new Product
            {
                Id = 1,
                Name = "BTestProduct",
                Categories = new HashSet<ProductsCategories>
                {
                    new ProductsCategories
                    {
                        CategoryId = 1,
                        ProductId = 1
                    }
                }
            });
            db.Products.Add(new Product
            {
                Id = 2,
                Name = "ATestProduct",
                Categories = new HashSet<ProductsCategories>
                {
                    new ProductsCategories
                    {
                        CategoryId = 1,
                        ProductId = 2
                    }
                }
            });
            db.SaveChanges();

            return new ProductsService(db);
        }
    }
}
