namespace Pharmacy.Services.Shop.Implementations
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper.QueryableExtensions;
    using Pharmacy.Common;
    using Pharmacy.Data;
    using Pharmacy.Services.Admin.Models;
    using Pharmacy.Services.Shop.Models;

    public class OrdersService : IOrdersService, IService
    {
        private readonly PharmacyDbContext db;

        public OrdersService(PharmacyDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<OrdersServiceModel> ByUser(string id, int page)
            => this.db
                .Orders
                .Where(o => o.UserId == id)
                .Skip((page - 1) * GlobalConstants.PageItems)
                .Take(GlobalConstants.PageItems)
                .ProjectTo<OrdersServiceModel>()
                .OrderByDescending(osm => osm.DateOfOrdering)
                .ToList();

        public int Count(string id)
            => this.db.Orders.Where(o => o.UserId == id).Count();

        public OrdersDetailsServiceModel OrderById(int id)
            => this.db
                .Orders
                .Where(o => o.Id == id)
                .ProjectTo<OrdersDetailsServiceModel>()
                .FirstOrDefault();
         
    }
}
