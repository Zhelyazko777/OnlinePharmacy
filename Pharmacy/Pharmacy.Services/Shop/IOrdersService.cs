namespace Pharmacy.Services.Shop
{
    using Pharmacy.Services.Shop.Models;
    using System.Collections.Generic;

    public interface IOrdersService
    {
        IEnumerable<OrdersServiceModel> ByUser(string id, int page);

        int Count(string id);
        
        OrdersDetailsServiceModel OrderById(int id);
    }
}
