namespace Pharmacy.Services.Shop.Models
{
    using Pharmacy.Common.Mapping;
    using Pharmacy.Models;
    using System;
    using System.Collections.Generic;

    public class OrdersDetailsServiceModel: IMapFrom<Order>
    {
        public int Id { get; set; }

        public DateTime DateOfOrdering { get; set; }

        public IEnumerable<OrderItemsServiceModel> Items { get; set; }

        public string UserId { get; set; }
    }
}
