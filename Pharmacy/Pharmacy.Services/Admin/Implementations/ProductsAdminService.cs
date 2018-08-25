namespace Pharmacy.Services.Admin.Implementations
{
    using Microsoft.AspNetCore.Http;
    using Pharmacy.Common;
    using Pharmacy.Data;
    using Pharmacy.Models;
    using Pharmacy.Services.Admin.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ProductsAdminService : IProductsAdminService, IService
    {
        private readonly PharmacyDbContext db;

        public ProductsAdminService(PharmacyDbContext db)
        {
            this.db = db;
        }

        public async Task<bool> AddAsync(string name, int categoryId, string description, decimal price, long barcode, int drugTypeId, IFormFile image, string imageName)
        {
            var drug = this.db.DrugIngredients.Where(di => di.Id == drugTypeId).Select(di => di.Name).FirstOrDefault();
            var category = this.db.Categories.Where(c => c.Id == categoryId).Select(c => c.Name).FirstOrDefault();

            if (CustomValidator.CheckIfObjectNull(drug) || CustomValidator.CheckIfObjectNull(category))
            {
                return false;
            }

            var parentCategoryId = this.db
                .Categories
                .Where(c => c.Id == categoryId)
                .Select(c => c.ParentCategoryId)
                .FirstOrDefault();  

            var product = new Product
            {
                Name = name,
                Description = description,
                Price = price,
                DrugTypeId = drugTypeId,
                Barcode = barcode,
                AddDate = DateTime.UtcNow,
                ImgName = imageName
            };

            this.db
                  .Add(product);

            this.db
                .ProductsCategories
                .Add(new ProductsCategories
                {
                    CategoryId = categoryId,
                    Product = product
                });

            if (parentCategoryId != null)
            {
                this.db
                    .ProductsCategories
                    .Add(new ProductsCategories
                    {
                        CategoryId = (int)parentCategoryId,
                        Product = product
                    });
            }

            await this.db.SaveChangesAsync();

            return true;
        }

        public IEnumerable<DrugTypesDropDownModel> GetDrugTypeDropDown()
            => this.db
                    .DrugIngredients
                    .Select(dt => new DrugTypesDropDownModel
                    {
                        Text = dt.Name,
                        Value = dt.Id
                    })
                    .ToList();

        public string DeleteProduct(int id)
        {
            var product = this.db
                .Products
                .Where(p => p.Id == id)
                .FirstOrDefault();

            if (CustomValidator.CheckIfObjectNull(product))
            {
                return "";
            }
            
            var productName = product.Name;

            this.db
                .Products
                .Remove(product);

            this.db.SaveChanges();

            return productName;
        }

        public Product GetProduct(int id)
            => this.db
                .Products
                .Where(p => p.Id == id)
                .FirstOrDefault();

        public string Update(int id, string name, int categoryId, string description, decimal price, long barcode, int drugTypeId)
        {
            var product = this.db
                .Products
                .Find(id);
            
            product.Name = name;
            product.Description = description;
            product.Price = price;
            product.Barcode = barcode;
            product.DrugTypeId = drugTypeId;
            product.Categories.Select(c => c.CategoryId = categoryId);
            
            this.db.SaveChanges();

            return product.Name;
        }

        //public string UpdateProduct(int id, string name, int categoryId, string description, decimal price, long barcode, int drugTypeId, IFormFile image, string imageName)
        //{
        //    var product = this.db.Products.Find(id);



        //}

        //private async Task<string> SaveImagesAsync(string name, IFormFile file)
        //{
        //    var extention = file.FileName.Split('.').ToArray()[1];
        //    var fileName = name + "." + extention;

        //    var path = Path.Combine("\\..\\", Directory.GetCurrentDirectory(), "wwwroot\\ProductsImages\\", fileName);

        //    using (var fileStream = new FileStream(path, FileMode.Create))
        //    {
        //        await file.CopyToAsync(fileStream);
        //    };

        //    return fileName;
        //}
    }
}
