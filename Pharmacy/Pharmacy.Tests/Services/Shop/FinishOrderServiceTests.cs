namespace Pharmacy.Tests.Services.Shop
{
    using Xunit;
    using FluentAssertions;
    using Pharmacy.Services.Shop.Implementations;
    using Pharmacy.Models;
    using System.Collections.Generic;
    using Pharmacy.Services.Shop.Models;

    public class FinishOrderServiceTests: BaseTest
    {
        public FinishOrderServiceTests()
        {
            Test.Initialize();
        }

        [Fact]
        public void FinishOrderShouldAddOrderWithItemsToDb()
        {
            var db = this.InitializeDb();
            var service = new FinishOrderService(db);
            service.FinishOrder(new List<CartItemModel> { new CartItemModel {  Name = "TestItem1" } }, "testUserId");
            db.Orders.Should().HaveCount(1);
            db.OrderItems.Should().HaveCount(1);
        }
    }
}
