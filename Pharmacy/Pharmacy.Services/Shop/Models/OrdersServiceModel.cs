namespace Pharmacy.Services.Shop.Models
{
    using Pharmacy.Common.Mapping;
    using Pharmacy.Models;
    using System;

    public class OrdersServiceModel: IMapFrom<Order>
    {
        public int Id { get; set; }

        public DateTime DateOfOrdering { get; set; }

        public bool IsRead { get; set; }
    }
}
