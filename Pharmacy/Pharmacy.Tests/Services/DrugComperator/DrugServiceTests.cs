namespace Pharmacy.Tests.Services.DrugComperator
{
    using Xunit;
    using FluentAssertions;
    using Pharmacy.Models;
    using Pharmacy.Services.DrugComperator.Implementations;
    using System.Linq;

    public class DrugServiceTests: BaseTest
    {
        public DrugServiceTests()
        {
            Test.Initialize();
        }

        [Fact]
        public void GenericDrugsByIdWithCorrectIdShouldReturnGenericsOrderedByPrice()
        {
            var service = this.GetDrugsServiceWithData();
            service.GenericDrugsById(1, 1).Should().HaveCount(2).And.Match(p => p.ElementAt(0).Id == 3);
        }

        [Fact]
        public void GenericDrugsWithWrongIdShouldReturnEmptyCollection()
        {
            var service = this.GetDrugsServiceWithData();
            service.GenericDrugsById(100, 1).Should().HaveCount(0);
        }

        [Fact]
        public void NumOfGenericsWithCorrectIdShouldReturnAllGenericProducts()
        {
            var service = this.GetDrugsServiceWithData();
            service.NumOfGenerics(1).Should().Be(2);
        }

        private DrugService GetDrugsServiceWithData()
        {
            var db = this.InitializeDb();
            db.DrugIngredients.Add(new DrugIngredient { Id = 1, Name = "TestIngredient" });
            db.Products.Add(new Product { Id = 1, Name = "TestProduct1", DrugTypeId = 1, Price = 200});
            db.Products.Add(new Product { Id = 2, Name = "TestProduct2", DrugTypeId = 1, Price = 100 });
            db.Products.Add(new Product { Id = 3, Name = "TestProduct3", DrugTypeId = 1, Price = 1});
            db.SaveChanges();

            return new DrugService(db);
        }
    }
}
