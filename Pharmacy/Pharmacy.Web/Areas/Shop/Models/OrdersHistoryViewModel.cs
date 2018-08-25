namespace Pharmacy.Web.Areas.Shop.Models
{
    using Pharmacy.Common;
    using Pharmacy.Services.Shop.Models;
    using System.Collections.Generic;

    public class OrdersHistoryViewModel: ViewModelWithPages 
    {
        public IEnumerable<OrdersServiceModel> Orders { get; set; }
    }
}
