namespace Pharmacy.Tests.Services.Shop
{
    using Xunit;
    using FluentAssertions;
    using Pharmacy.Services.Shop.Implementations;
    using Pharmacy.Models;
    using System;
    using System.Linq;

    public class OrdersServiceTests: BaseTest
    {
        public OrdersServiceTests()
        {
            Test.Initialize();
        }

        [Fact]
        public void ByUserShouldReturnAllOrdersOfTheUser()
        {
            var service = this.GetOrdersServiceWithDate();
            service.ByUser("1", 1).Should().HaveCount(2).And.Match(o => o.ElementAt(0).Id == 2);
        }

        [Fact]
        public void CountShouldReturnCountOfAllOrdersOfUser()
        {
            var service = this.GetOrdersServiceWithDate();
            service.Count("1").Should().Be(2);
        }

        [Fact]
        public void OrderByIdWithWrongIdShouldReturnNull()
        {
            var service = this.GetOrdersServiceWithDate();
            service.OrderById(100).Should().BeNull();
        }

        [Fact]
        public void OrderByIdWithCorrectIdShouldReturnOrder()
        {
            var service = this.GetOrdersServiceWithDate();
            var order = service.OrderById(1);
            order.Should().NotBeNull();
            order.Id.Should().Be(1);
        }

        private OrdersService GetOrdersServiceWithDate()
        {
            var db = this.InitializeDb();
            db.Users.Add(new User { Id = "1", UserName = "TestUser" });
            db.Orders.Add(new Order { UserId = "1", Id = 1, DateOfOrdering = DateTime.UtcNow });
            db.Orders.Add(new Order { UserId = "1", Id = 2, DateOfOrdering = DateTime.UtcNow.AddDays(2) });
            db.SaveChanges();

            return new OrdersService(db);
        }
    }
}
