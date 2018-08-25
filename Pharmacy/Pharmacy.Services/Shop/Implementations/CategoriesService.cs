namespace Pharmacy.Services.Shop.Implementations
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper.QueryableExtensions;
    using Pharmacy.Data;
    using Pharmacy.Services.Shop.Models;

    public class CategoriesService : ICategoriesService, IService
    {
        private readonly PharmacyDbContext db;

        public CategoriesService(PharmacyDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<CategoriesServiceModel> All()
            => this.db
                .Categories
                .ProjectTo<CategoriesServiceModel>()
                .OrderBy(csm => csm.Name)
                .ToList();

        public bool IsCatgoryExists(int id)
        {
            if (this.db.Categories.Any(c => c.Id == id))
            {
                return true;
            }

            return false;
        }

        //public IEnumerable<CategoriesServiceModel> TopParents()
        //    => this.db
        //        .Categories
        //        .Where(c => c.ParentCategory == null)
        //        .ProjectTo<CategoriesServiceModel>()
        //        .ToList();

        //public IEnumerable<CategoriesServiceModel> Children(int parentId)
        //    => this.db
        //        .Categories
        //        .Where(c => c.ParentCategoryId == parentId)
        //        .ProjectTo<CategoriesServiceModel>()
        //        .ToList();
    }
}
