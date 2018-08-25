namespace Pharmacy.Services.Admin.Models
{
    using AutoMapper;
    using Pharmacy.Common.Mapping;
    using Pharmacy.Models;
    using Pharmacy.Services.Shop.Models;
    using System;
    using System.Collections.Generic;

    public class OrderWithDetailsServiceModel: /*IMapFrom<Order>,*/ IHaveCustomMapping
    {
        public int Id { get; set; }

        public DateTime DateOfOrdering { get; set; }

        public IEnumerable<OrderItemsServiceModel> Items { get; set; }

        public string UserAddress { get; set; }

        public string Username { get; set; }

        public void ConfigureMapping(Profile profile)
        {
            profile.CreateMap<Order, OrderWithDetailsServiceModel>()
                .ForMember(owd => owd.UserAddress, opt => opt.MapFrom(o => o.User.Address));

            profile.CreateMap<Order, OrderWithDetailsServiceModel>()
                .ForMember(owd => owd.Username, opt => opt.MapFrom(o => o.User.UserName));

            //profile.CreateMap<OrderItem, OrderWithDetailsServiceModel>()
            //    .ForMember(owd => owd.Items, opt => opt.MapFrom(oi => new OrderItemsServiceModel
            //    {
            //        Id = oi.Id,
            //        Name = oi.Name,
            //        Price = oi.Price,
            //        Quantity = oi.Quantity
            //    }));
        }
    }
}
