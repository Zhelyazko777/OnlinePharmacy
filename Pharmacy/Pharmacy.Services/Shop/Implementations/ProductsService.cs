namespace Pharmacy.Services.Shop.Implementations
{
    using AutoMapper.QueryableExtensions;
    using Pharmacy.Common;
    using Pharmacy.Data;
    using Pharmacy.Models;
    using Pharmacy.Services.Shop.Models;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class ProductsService : IProductsService, IService
    {
        private readonly PharmacyDbContext db;

        public ProductsService(PharmacyDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<ProductsServiceModel> All(int page)
            => this
                .ProductsWithoutDetails()
                .Skip((page - 1) * GlobalConstants.PageItems)
                .Take(GlobalConstants.PageItems)
                .OrderBy(p => p.Name)
                .ToList();

        public IEnumerable<ProductsServiceModel> ByCategory(int id, int page)
            =>  this
                .ProductsWithoutDetails()
                .Where(p => p.CategoriesIds.Contains(id))
                .Skip((page - 1) * GlobalConstants.PageItems)
                .Take(GlobalConstants.PageItems)
                .OrderBy(p => p.Name)
                .ToList();
            
        public ProductsWithDetailsServiceModel ById(int id)
            => this.db
                  .Products
                  .Where(p => p.Id == id)
                  .ProjectTo<ProductsWithDetailsServiceModel>()
                  .FirstOrDefault();
        
        
        public CartItemModel GetProductInfoForCartById(int id)
            => this.db
                .Products
                .Where(p => p.Id == id)
                .ProjectTo<CartItemModel>()
                .FirstOrDefault();

        public IEnumerable<ProductsDropDownModel> GetProductsDropDown()
            => this.db
                .Products
                .ProjectTo<ProductsDropDownModel>()
                .OrderBy(pddm => pddm.Name)
                .ToList();

        public int NumOfProducts()
            => this.db.Products.Count();

        public int NumOfProductsInCategory(int id)
            => this.db.Categories.Where(c => c.Id == id).Select(c => c.Products.Count()).FirstOrDefault();

        private IQueryable<ProductsServiceModel> ProductsWithoutDetails()
            => this.db
                .Products
                .ProjectTo<ProductsServiceModel>();
    }
}
