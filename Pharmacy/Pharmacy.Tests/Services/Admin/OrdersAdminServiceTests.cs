namespace Pharmacy.Tests.Services.Admin
{
    using FluentAssertions;
    using Pharmacy.Models;
    using Pharmacy.Services.Admin.Implementations;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class OrdersAdminServiceTests : BaseTest
    {
        public OrdersAdminServiceTests()
        {
            Test.Initialize();
        }

        [Fact]
        public void AllShouldReturnAllOrdersOrderedByIsReadThenByDateOfOrdering()
        {
            var service = this.GetOrdersServiceWithDate();
            service.All(1).Should().HaveCount(4).And.Match(o => o.ElementAt(0).Id == 4 && o.ElementAt(1).Id == 3);
        }

        [Fact]
        public void OrderByIdShouldReturnCorrectOrder()
        {
            var service = this.GetOrdersServiceWithDate();
            service.OrderById(1).Id.Should().Be(1);
        }

        [Fact]
        public void AllUreadedShouldRetunOrdersOrderedByDate()
        {
            var service = this.GetOrdersServiceWithDate();
            service.AllUreaded(1).Should().HaveCount(2).And.Match(o => o.ElementAt(0).Id == 4);
        }

        [Fact]
        public void MarkAsReadWithCorrectIdShouldReturnTrueAndMarkOrderAsRead()
        {
            var db = this.InitializeDb();
            db.Users.Add(new User { Id = "1", UserName = "TestUser" });
            db.Orders.Add(new Order
            {
                Id = 1,
                DateOfOrdering = DateTime.UtcNow,
                UserId = "1",
                Items = new HashSet<OrderItem>
                {
                    new OrderItem
                    {
                        Id = 1,
                        OrderId = 2,
                        Name = "TestItem2",
                        Price = 100.5M,
                        Quantity = 10
                    }
                },
                IsRead = false
            });
            db.SaveChanges();

            var service = new OrdersAdminService(db);
            service.MarkAsRead(1).Should().BeTrue();
            db.Orders.Find(1).IsRead.Should().BeTrue();
        }

        [Fact]
        public void MarkAsReadWithWrongIdShouldReturnFalse()
        {
            var db = this.InitializeDb();
            var service = new OrdersAdminService(db);
            service.MarkAsRead(1).Should().BeFalse();
        }

        [Fact]
        public void NumOfAllOrdersShoulReturnCorrectCount()
        {
            var service = this.GetOrdersServiceWithDate();
            service.NumOfAll().Should().Be(4);
        }

        [Fact]
        public void NumOfUnreadedShouldReturnCorrectCount()
        {
            var service = this.GetOrdersServiceWithDate();
            service.NumOfUnread().Should().Be(2);
        }

        private OrdersAdminService GetOrdersServiceWithDate()
        {
            var db = this.InitializeDb();
            var date = DateTime.UtcNow;
            
            db.Users.Add(new User { Id = "1", UserName = "TestUser" });
            db.Orders.Add(new Order
            {
                Id = 1,
                DateOfOrdering = date.AddDays(10),
                UserId = "1",
                Items = new HashSet<OrderItem>
                {
                    new OrderItem
                    {
                        Id = 1,
                        OrderId = 2,
                        Name = "TestItem2",
                        Price = 100.5M,
                        Quantity = 10
                    }
                },
                IsRead = true
            });
            db.Orders.Add(new Order
            {
                Id = 2,
                DateOfOrdering = date.AddDays(1),
                UserId = "1",
                Items = new HashSet<OrderItem>
                {
                    new OrderItem
                    {
                        Id = 2,
                        OrderId = 2,
                        Name = "TestItem",
                        Price = 5.50M,
                        Quantity = 2
                    }
                },
                IsRead = true
            });
            db.Orders.Add(new Order
            {
                Id = 3,
                DateOfOrdering = date.AddDays(1),
                UserId = "1",
                Items = new HashSet<OrderItem>
                {
                    new OrderItem
                    {
                        Id = 3,
                        OrderId = 3,
                        Name = "TestItem",
                        Price = 5.50M,
                        Quantity = 2
                    }
                },
                IsRead = false
            });
            db.Orders.Add(new Order
            {
                Id = 4,
                DateOfOrdering = date.AddDays(2),
                UserId = "1",
                Items = new HashSet<OrderItem>
                {
                    new OrderItem
                    {
                        Id = 4,
                        OrderId = 4,
                        Name = "TestItem",
                        Price = 5.50M,
                        Quantity = 2
                    }
                },
                IsRead = false
            });
            db.SaveChanges();

            return new OrdersAdminService(db);
        }
    }
}
