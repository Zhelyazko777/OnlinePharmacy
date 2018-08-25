namespace Pharmacy.Services.Shop.Implementations
{
    using Pharmacy.Data;
    using Pharmacy.Models;
    using Pharmacy.Services.Shop.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FinishOrderService : IFinishOrderService, IService
    {
        private readonly PharmacyDbContext db;

        public FinishOrderService(PharmacyDbContext db)
        {
            this.db = db;
        }

        public void FinishOrder(IEnumerable<CartItemModel> items, string userId)
        {
            var order = new Order
            {
                UserId = userId,
                FinalSum = items.Select(i => i.Price * i.Quantity).Sum(),
                DateOfOrdering = DateTime.UtcNow
            };

            this.db
                .Orders
                .Add(order);

            foreach (var item in items)
            {
                this.db
                    .OrderItems
                    .Add(new OrderItem
                    {
                        Name = item.Name,
                        Order = order,
                        Price = item.Price,
                        Quantity = item.Quantity
                    });
            }

            this.db.SaveChanges();
        }
    }
}