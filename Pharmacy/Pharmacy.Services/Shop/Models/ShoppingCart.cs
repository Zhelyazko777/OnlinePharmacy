namespace Pharmacy.Services.Shop.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingCart
    {
        private readonly IList<CartItemModel> items;

        public ShoppingCart()
        {
            this.items = new List<CartItemModel>();
        }

        public IEnumerable<CartItemModel> Items => new List<CartItemModel>(this.items);

        public void AddToCart(CartItemModel model)
        {
            var item = this.GetItemByProductId(model.ProductId);

            if (item == null)
            {
                this.items.Add(model);
            }
            else
            {
                item.Quantity+=model.Quantity;
            }
        }

        public void UpdateQuantity(int productId, int quantity)
        {
            var carItem = this.GetItemByProductId(productId);

            if (carItem != null)
            {
                var item = this.items.FirstOrDefault(i => i.ProductId == productId);
                item.Quantity = quantity;
            }
        }


        public void RemoveFromCart(int productId)
        {
            var cartItem = this.GetItemByProductId(productId);

            if (cartItem != null)
            {
                this.items.Remove(cartItem);
            }
        }

        public void DeleteCart()
        {
            this.items.Clear();
        }

        private CartItemModel GetItemByProductId(int id)
        {
            return this.items.FirstOrDefault(p => p.ProductId == id);
        }

    }
}
