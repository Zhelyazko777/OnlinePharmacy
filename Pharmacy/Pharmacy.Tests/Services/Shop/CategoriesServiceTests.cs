namespace Pharmacy.Tests.Services.Shop
{
    using Xunit;
    using FluentAssertions;
    using Pharmacy.Services.Shop.Implementations;
    using Pharmacy.Models;
    using System.Linq;

    public class CategoriesServiceTests: BaseTest
    {
        public CategoriesServiceTests()
        {
            Test.Initialize();
        }

        [Fact]
        public void AllShouldReturnallCategoriesOrderedAlphabeticly()
        {
            var service = this.GetCategoriesServiceWithData();
            service.All().Should().Match(c => c.ElementAt(0).Id == 2);
        }

        [Fact]
        public void IsCategoryExistWithCorrectIdShouldReturnTrue()
        {
            var service = this.GetCategoriesServiceWithData();
            service.IsCatgoryExists(1).Should().BeTrue();
        }

        [Fact]
        public void IsCategoryExistWithWrongIdShouldReturnFalse()
        {
            var service = this.GetCategoriesServiceWithData();
            service.IsCatgoryExists(100).Should().BeFalse();
        }

        private CategoriesService GetCategoriesServiceWithData()
        {
            var db = this.InitializeDb();
            db.Categories.Add(new Category { Id = 1, Name = "Ctest" });
            db.Categories.Add(new Category { Id = 2, Name = "Atest" });
            db.Categories.Add(new Category { Id = 3, Name = "Btest" });
            db.SaveChanges();

            return new CategoriesService(db);
        }
    }
}
