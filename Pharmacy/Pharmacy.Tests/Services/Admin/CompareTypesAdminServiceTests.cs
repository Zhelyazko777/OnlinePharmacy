namespace Pharmacy.Tests.Services.Admin
{
    using Xunit;
    using FluentAssertions;
    using Pharmacy.Services.Admin.Implementations;
    using Pharmacy.Models;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Identity;

    public class CompareTypesAdminServiceTests: BaseTest
    {
        public CompareTypesAdminServiceTests()
        {
            Test.Initialize();
        }

        [Fact]
        public void AllShouldReturnAllDrugIngredientsOrderedAlphabeticly()
        {
            var service = this.GetCompareTypesAdminServiceWithData();
            service.All(1).Should().HaveCount(3).And.Match(i => i.ElementAt(0).Id == 2);
        }


        [Fact]
        public void AllShouldNotHaveIngredientsOnSecondPage()
        {
            var service = this.GetCompareTypesAdminServiceWithData();
            service.All(2).Should().HaveCount(0);
        }

        [Fact]
        public void AddShouldAddNewDrugIngredient()
        {
            var db = this.InitializeDb();

            var service = new CompareTypesAdminService(db);
            service.Add("Test");
            db.DrugIngredients.Should().HaveCount(1);
        }
        
        [Fact]
        public void AddCrossShouldAddNewCrossToSomeIngredient()
        {
            var db = this.InitializeDb();
            db.DrugIngredients.Add(new DrugIngredient { Id = 1, Name = "test1" });
            db.DrugIngredients.Add(new DrugIngredient { Id = 2, Name = "test2" });
            db.SaveChanges();

            var service = new CompareTypesAdminService(db);
            service.AddCross(1, 2).Should().BeTrue();
            db.Find<CrossIngredient>(1, 2).Should().NotBeNull();
        }

        [Fact]
        public void AddCrossWithWrongParamsShouldReturnFalse()
        {
            var db = this.InitializeDb();

            var service = new CompareTypesAdminService(db);
            service.AddCross(1, 2).Should().BeFalse();
            db.Find<CrossIngredient>(1, 2).Should().BeNull();
        }

        [Fact]
        public void DeleteShouldDeleteIngredient()
        {
            var db = this.InitializeDb();
            db.DrugIngredients.Add(new DrugIngredient { Id = 1, Name = "test1" });
            db.DrugIngredients.Add(new DrugIngredient { Id = 2, Name = "test2" });
            db.SaveChanges();

            var service = new CompareTypesAdminService(db);
            service.Delete(1);
            db.DrugIngredients.Should().HaveCount(1);
        }

        [Fact]
        public void GetIngredientShouldReturnIngredient()
        {
            var service = this.GetCompareTypesAdminServiceWithData();

            service.GetIngridient(2).Name.Should().Match("ATest2");
        }

        [Fact]
        public void UpdateWithCorrectDataShouldUpdateCorrectlyAndReturnFalse()
        {
            var db = this.InitializeDb();
            db.DrugIngredients.Add(new DrugIngredient { Id = 1, Name = "test1" });
            db.SaveChanges();

            var service = new CompareTypesAdminService(db);
            service.Update(1, "updated").Should().BeTrue();
            db.DrugIngredients.Find(1).Name.Should().Match("updated");
        }

        [Fact]
        public void UpdateWithWrongIdShouldReturnFalse()
        {
            var db = this.InitializeDb();

            var service = new CompareTypesAdminService(db);
            service.Update(1, "test").Should().BeFalse();
            db.DrugIngredients.Where(di => di.Id == 1).FirstOrDefault().Should().BeNull();
        }

        [Fact]
        public void CrossIngredientsByIdShouldReturnAllCrossIngredientsByIdInAphabeticlyOrder()
        {
            var service = this.GetCompareTypesAdminServiceWithData();

            service.CrossIngredientsById(2).Should().HaveCount(2).And.Match(ci => ci.ElementAt(0) == "BTest3");
        }

        private CompareTypesAdminService GetCompareTypesAdminServiceWithData()
        {
            var db = this.InitializeDb();
            db.DrugIngredients.Add(new DrugIngredient
            {
                Id = 1,
                Name = "CTest1",
                CrossIngredients = new HashSet<CrossIngredient>
                {
                    new CrossIngredient
                    {
                        DrugIngredientId = 1,
                        CrossId = 2
                    }
                }
            });

            db.DrugIngredients.Add(new DrugIngredient
            {
                Id = 2,
                Name = "ATest2",
                CrossIngredients = new HashSet<CrossIngredient>
                {
                    
                    
                    new CrossIngredient
                    {
                        DrugIngredientId = 2,
                        CrossId = 1
                    },
                    new CrossIngredient
                    {
                         DrugIngredientId = 2,
                         CrossId = 3
                    },
                }
            });
            db.DrugIngredients.Add(new DrugIngredient
            {
                Id = 3,
                Name = "BTest3",
                CrossIngredients = new HashSet<CrossIngredient>
                {
                    new CrossIngredient
                    {
                        CrossId = 2,
                        DrugIngredientId = 3
                    }
                }
            }
            );

            db.SaveChanges();

            return new CompareTypesAdminService(db);
        }
    }
}
