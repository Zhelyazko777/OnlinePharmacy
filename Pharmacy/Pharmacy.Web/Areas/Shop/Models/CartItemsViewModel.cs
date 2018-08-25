using Pharmacy.Services.Shop.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pharmacy.Web.Areas.Shop.Models
{
    public class CartItemsViewModel
    {
        public IEnumerable<CartItemModel> CartItems { get; set; }

        public decimal AllMoney
        {
            get
            {
                return this.CartItems.Select(ci => ci.Price * ci.Quantity).Sum();
            }
        }
    }
}
