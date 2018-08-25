namespace Pharmacy.Tests.Services.Admin
{
    using FluentAssertions;
    using Pharmacy.Models;
    using Pharmacy.Services.Admin.Implementations;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    public class ProductsAdminServiceTests: BaseTest
    {
        public ProductsAdminServiceTests()
        {
            Test.Initialize();
        }

        [Fact]
        public async Task AddAsyncWithCorectDataShouldAddCorrectProduct()
        {
            var db = this.InitializeDb();
            db.Categories.Add(new Category { Id = 1, Name = "TestCategory" });
            db.DrugIngredients.Add(new DrugIngredient { Id = 1, Name = "TestIngredient" });
            db.SaveChanges();

            var service = new ProductsAdminService(db);
            var result = await service.AddAsync("TestProduct", 1, null, 0, 0, 1, null, null);
            result.Should().BeTrue();

            db.Products.Should().HaveCount(1);
        }

        [Fact]
        public async Task AddAsyncWithNullCategoryShouldReturnFalseAndNotWriteInDb()
        {
            var db = this.InitializeDb();;
            db.DrugIngredients.Add(new DrugIngredient { Id = 1, Name = "TestIngredient" });
            db.SaveChanges();

            var service = new ProductsAdminService(db);
            var result = await service.AddAsync("TestProduct", 1, null, 0, 0, 1, null, null);
            result.Should().BeFalse();

            db.Products.Should().HaveCount(0);
        }

        [Fact]
        public async Task AddAsyncWithNullDrugIngredientShoulReturnFalseAndNotWriteInDb()
        {
            var db = this.InitializeDb();
            db.Categories.Add(new Category { Id = 1, Name = "TestCategory" });
            db.SaveChanges();

            var service = new ProductsAdminService(db);
            var result = await service.AddAsync("TestProduct", 1, null, 0, 0, 1, null, null);
            result.Should().BeFalse();

            db.Products.Should().HaveCount(0);
        }

        [Fact]
        public void DeleteProductShouldDeleteCorrectProduct()
        {
            var db = this.InitializeDb();
            db.Products.Add(new Product { Id = 1, Name = "TestProduct" });
            db.SaveChanges();

            var service = new ProductsAdminService(db);
            service.DeleteProduct(1);

            db.Products.Should().HaveCount(0);
        }

        [Fact]
        public void UpdateWithCorrectDataShouldUpdateCorrectly()
        {
            var db = this.InitializeDb();
            db.Categories.Add(new Category { Id = 1, Name = "TestCategory" });
            db.Products.Add(new Product
            {
                Id = 1,
                Name = "TestProduct",
                DrugTypeId = 1,
                Categories = new HashSet<ProductsCategories>
                {
                    new ProductsCategories
                    {
                        ProductId = 1,
                        CategoryId = 1
                    }
                }
            });
            db.SaveChanges();

            var service = new ProductsAdminService(db);
            service.Update(1, "Updated", 1, null, 0, 0, 1);
            db.Products.First().Should().Match<Product>(p => p.Name == "Updated");
        }

        [Fact]
        public void GetProductWithCorectIdShouldReturnProduct()
        {
            var db = this.InitializeDb();
            db.Categories.Add(new Category { Id = 1, Name = "TestCategory" });
            db.Products.Add(new Product
            {
                Id = 1,
                Name = "TestProduct",
                DrugTypeId = 1,
                Categories = new HashSet<ProductsCategories>
                {
                    new ProductsCategories
                    {
                        ProductId = 1,
                        CategoryId = 1
                    }
                }
            });
            db.SaveChanges();

            var service = new ProductsAdminService(db);
            service.GetProduct(1).Should().NotBeNull();
        }


    }
}
