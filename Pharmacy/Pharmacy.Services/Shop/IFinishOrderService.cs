namespace Pharmacy.Services.Shop
{
    using Pharmacy.Services.Shop.Models;
    using System.Collections.Generic;

    public interface IFinishOrderService
    {
        void FinishOrder(IEnumerable<CartItemModel> items, string userId);
    }
}
