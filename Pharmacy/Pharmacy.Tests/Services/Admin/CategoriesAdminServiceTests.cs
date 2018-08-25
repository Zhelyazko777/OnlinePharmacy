namespace Pharmacy.Tests.Services.Admin
{
    using FluentAssertions;
    using Pharmacy.Models;
    using Pharmacy.Services.Admin.Implementations;
    using Xunit;
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class CategoriesAdminServiceTests:  BaseTest
    {
        public CategoriesAdminServiceTests()
        {
            Test.Initialize();
        }

        [Fact]
        public void ShouldReturnAllTopCategoriesOrderedAlphabeticly()
        {
            var service = this.GetCategoriesAdminServiceWithData();

            service
                .Top()
                .Should()
                .HaveCount(2)
                .And
                .Match(c => c.ElementAt(0).Id == 7);
        }

        [Fact]
        public void ShouldReturnAllChildrenOfCategoryOrderedAlphabeticly()
        {
            var service = this.GetCategoriesAdminServiceWithData();
            
            service
                .Children(6)
                .Should()
                .HaveCount(1)
                .And
                .Match(c => c.ElementAt(0).Id == 5);
        }

        [Fact]
        public void ShouldReturnOnlyCategoriesWithoutChildren()
        {
            var service = this.GetCategoriesAdminServiceWithData();

            service
                .GetCategoriesDropDown()
                .Should()
                .HaveCount(2)
                .And
                .Match(c => c.ElementAt(0).Value == 7);
        }

        [Fact]
        public void AddNullCategoryNameShouldReturnFalse()
        {
            var service = this.GetCategoriesAdminServiceWithData();

            var result = service.Add(null).Should().BeFalse();
        }

        [Fact]
        public void AddStringEmptyCategoryNameReturnsFalse()
        {
            var services = this.GetCategoriesAdminServiceWithData();

            var result = services.Add(String.Empty).Should().BeFalse();
        }

        [Fact]
        public void AddNotNullCategoryNameShouldReturnTrueAndAddNewCategory()
        {
            var db = this.InitializeDb();

            var service = new CategoriesAdminService(db);
            
            var result = service.Add("test").Should().BeTrue();
            
            db.Categories.Should().HaveCount(1);
        }

        [Fact]
        public void AddChiledCategorySetZeroForParametersShouldReturnFalse()
        {
            var service = this.GetCategoriesAdminServiceWithData();
            service.AddChiled(0, 0).Should().BeFalse();
            service.AddChiled(0, 5).Should().BeFalse();
            service.AddChiled(5, 0).Should().BeFalse();
        }

        private CategoriesAdminService GetCategoriesAdminServiceWithData()
        {
            var db = this.InitializeDb();   

            var firstCategory = new Category() { Id = 5, Name = "BTest1", ParentCategoryId = 6 };
            var secondCategory = new Category() { Id = 6, Name = "BTest2", ChiledCategories = new HashSet<Category>() { firstCategory } };
            var thirdCategory = new Category() { Id = 7, Name = "ATest3" };
            db.AddRange(firstCategory, secondCategory, thirdCategory);

            db.SaveChanges();

            var service = new CategoriesAdminService(db);

            return service;
        } 
    }
}
