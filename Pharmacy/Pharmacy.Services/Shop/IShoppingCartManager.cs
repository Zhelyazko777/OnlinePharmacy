namespace Pharmacy.Services.Shop
{
    using Pharmacy.Services.Shop.Models;
    using System.Collections.Generic;

    public interface IShoppingCartManager
    {
        void AddToCart(string id, CartItemModel model);

        void UpdateQuantity(string id, int productId, int quantity);

        void RemoveFromCart(string id, int productId);

        void DeleteCart(string id);

        IEnumerable<CartItemModel> GetItems(string id);

        //void FinishOrder(IEnumerable<CartItemModel> items, string userId);
    }
}
