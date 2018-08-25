namespace Pharmacy.Web.Areas.Admin.Models
{
    using Pharmacy.Common;
    using Pharmacy.Services.Admin.Models;
    using Pharmacy.Services.Shop.Models;
    using System.Collections.Generic;

    public class OrdersViewModel: ViewModelWithPages
    {
        public IEnumerable<OrdersServiceModel> Orders { get; set; }
    }
}
