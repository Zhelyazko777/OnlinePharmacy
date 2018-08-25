namespace Pharmacy.Services.Shop.Implementations
{
    using Pharmacy.Services.Shop.Models;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using Pharmacy.Data;
    using Pharmacy.Models;
    using System;

    public class ShoppingCartManager : IShoppingCartManager
    {
        private readonly ConcurrentDictionary<string, ShoppingCart> carts;
        //private readonly PharmacyDbContext db;

        public ShoppingCartManager()
        {
            //this.db = db;
            this.carts = new ConcurrentDictionary<string, ShoppingCart>();
        }

        public void AddToCart(string id, CartItemModel model)
        {
            var shoppingCart = this.GetCart(id);

            shoppingCart.AddToCart(model);
        }

        public void DeleteCart(string id)
        {
            var shoppingCart = this.GetCart(id);

            shoppingCart.DeleteCart();
        }
        
        public void RemoveFromCart(string id, int productId)
        {
            var shoppingCart = this.GetCart(id);

            shoppingCart.RemoveFromCart(productId);
        }

        public void UpdateQuantity(string id, int productId, int quantity)
        {
            var shoppingCart = this.GetCart(id);

            shoppingCart.UpdateQuantity(productId, quantity);
        }

        public IEnumerable<CartItemModel> GetItems(string id)
        {
            var shoppingCart = this.GetCart(id);

            return new List<CartItemModel>(shoppingCart.Items);
        }

        private ShoppingCart GetCart(string id)
            => this.carts.GetOrAdd(id, new ShoppingCart());

        //public void FinishOrder(IEnumerable<CartItemModel> items, string userId)
        //{
        //    var order = new Order
        //    {
        //        UserId = userId,
        //        DateOfOrdering = DateTime.UtcNow
        //    };

        //    this.db
        //        .Orders
        //        .Add(order);

        //    foreach (var item in items)
        //    {
        //        this.db
        //            .OrderItems
        //            .Add(new OrderItem
        //            {
        //                Name = item.Name,
        //                Order = order,
        //                Price = item.Price,
        //                Quantity = item.Quantity
        //            });
        //    }

        //    this.db.SaveChanges();
        //}
    }
}
