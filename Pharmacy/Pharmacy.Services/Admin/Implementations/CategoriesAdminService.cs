namespace Pharmacy.Services.Admin.Implementations
{
    using Pharmacy.Data;
    using Pharmacy.Models;
    using Pharmacy.Services.Admin.Models;
    using System.Linq;
    using System.Collections.Generic;
    using AutoMapper.QueryableExtensions;
    using System;
    using Pharmacy.Common;

    public class CategoriesAdminService : ICategoriesAdminService, IService
    {
        private readonly PharmacyDbContext db;

        public CategoriesAdminService(PharmacyDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<CategoriesAdminServiceModel> Top()
            => this.db
                .Categories
                .Where(c => c.ParentCategory == null)
                .ProjectTo<CategoriesAdminServiceModel>()
                .OrderBy(csm => csm.Name)
                .ToList();

        public IEnumerable<CategoriesAdminServiceModel> Children(int id)
            => this.db
                .Categories
                .Where(c => c.Id == id)
                .Select(c => c.ChiledCategories
                    .Select(cc => new CategoriesAdminServiceModel
                    {
                        Id = cc.Id,
                        Name = cc.Name
                    }))
                .FirstOrDefault();

        //Returns only categories without children
        public IEnumerable<CategoriesDropDownModel> GetCategoriesDropDown()
            => this.db
                    .Categories
                    .Where(c => c.ChiledCategories.Count() == 0)
                    .Select(c => new CategoriesDropDownModel
                    {
                        Text = c.Name,
                        Value = c.Id
                    })
                    .OrderBy(c => c.Text)
                    .ToList();

        public bool Add(string name)
        {
            if (name == null || name == String.Empty)
            {
                return false;
            }

            this.db
                .Categories
                .Add(new Category
                {
                    Name = name
                });

            this.db.SaveChanges();

            return true;
        }

        public bool AddChiled(int parentId, int chiledId)
        {
            var parentCategory = this.db.Categories.Where(pc => pc.Id == parentId).FirstOrDefault();
            var chiledCategory = this.db.Categories.Where(cc => cc.Id == chiledId).FirstOrDefault();
            if (CustomValidator.CheckIfObjectNull(parentCategory) || CustomValidator.CheckIfObjectNull(chiledCategory))
            {
                return false;
            };

            parentCategory.ChiledCategories.Add(chiledCategory);

            this.db.SaveChanges();

            return true;
        }
    }
}
