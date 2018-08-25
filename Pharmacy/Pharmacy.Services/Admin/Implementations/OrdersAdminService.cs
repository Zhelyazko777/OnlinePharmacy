namespace Pharmacy.Services.Admin.Implementations
{
    using AutoMapper.QueryableExtensions;
    using Pharmacy.Common;
    using Pharmacy.Data;
    using Pharmacy.Models;
    using Pharmacy.Services.Admin.Models;
    using Pharmacy.Services.Shop.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class OrdersAdminService : IOrdersAdminService, IService
    {
        private readonly PharmacyDbContext db;

        public OrdersAdminService(PharmacyDbContext db)
        {
            this.db = db;
        }


        public IEnumerable<OrdersServiceModel> All(int page)
            => this.db
                .Orders
                .Skip((page - 1) * GlobalConstants.PageItems)
                .Take(GlobalConstants.PageItems)
                .ProjectTo<OrdersServiceModel>()
                .OrderBy(osm => osm.IsRead)
                .ThenByDescending(osm => osm.DateOfOrdering)
                .ToList();

        public OrderWithDetailsServiceModel OrderById(int id)
            => this.db
                .Orders
                .Where(o => o.Id == id)
                .ProjectTo<OrderWithDetailsServiceModel>()
                .FirstOrDefault();

        public IEnumerable<OrdersServiceModel> AllUreaded(int page)
            => this.db
                .Orders
                .Skip((page - 1) * GlobalConstants.PageItems)
                .Take(GlobalConstants.PageItems)
                .Where(o => o.IsRead == false)
                .ProjectTo<OrdersServiceModel>()
                .OrderByDescending(osm => osm.DateOfOrdering)
                .ToList();
        
        public bool MarkAsRead(int id)
        {
            var order = this
                .db
                .Orders
                .Where(o => o.Id == id)
                .FirstOrDefault();

            if (order == null)
            {
                return false;
            }

            order.IsRead = true;

            db.SaveChanges();

            return true;
        }

        public int NumOfUnread()
            => this.db
                .Orders
                .Where(o => o.IsRead == false)
                .Count();

        public int NumOfAll()
            => this.db.Orders.Count();
    }
}
