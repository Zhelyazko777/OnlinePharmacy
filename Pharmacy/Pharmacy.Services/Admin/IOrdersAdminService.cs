namespace Pharmacy.Services.Admin
{
    using Pharmacy.Models;
    using Pharmacy.Services.Admin.Models;
    using Pharmacy.Services.Shop.Models;
    using System.Collections.Generic;

    public interface IOrdersAdminService
    {
        IEnumerable<OrdersServiceModel> All(int page);

        OrderWithDetailsServiceModel OrderById(int id);

        int NumOfAll();

        IEnumerable<OrdersServiceModel> AllUreaded(int page);
        
        bool MarkAsRead(int id);

        int NumOfUnread();
    }
}
