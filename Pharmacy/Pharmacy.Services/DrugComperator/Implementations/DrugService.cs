namespace Pharmacy.Services.DrugComperator.Implementations
{
    using AutoMapper.QueryableExtensions;
    using Pharmacy.Data;
    using Pharmacy.Services.DrugComperator.Models;
    using System.Linq;
    using System.Collections.Generic;
    using Pharmacy.Common;

    public class DrugService : IDrugService, IService
    {
        private readonly PharmacyDbContext db;

        public DrugService(PharmacyDbContext db)
        {
            this.db = db;
        }


        public CrossServiceModel CrossDrugsById(int productId, int page)
        {
            var crossDrugs = this.db
                  .Products
                  .Where(p => p.Id == productId)
                  .ProjectTo<CrossServiceModel>()
                  .FirstOrDefault();

            var pagedCrossDrugs = new CrossServiceModel
            {
                Ids = crossDrugs.Ids.Skip((page - 1) * GlobalConstants.PageItems).Take(GlobalConstants.PageItems).ToList(),
                ImgNames = crossDrugs.ImgNames.Skip((page - 1) * GlobalConstants.PageItems).Take(GlobalConstants.PageItems).ToList(),
                Prices = crossDrugs.Prices.Skip((page - 1) * GlobalConstants.PageItems).Take(GlobalConstants.PageItems).ToList(),
                Names = crossDrugs.Names.Skip((page - 1) * GlobalConstants.PageItems).Take(GlobalConstants.PageItems).ToList(),
                BaseProductId = productId
            };

            return pagedCrossDrugs;
        }

        public IEnumerable<GenericServiceModel> GenericDrugsById(int productId, int page)
        {
            var activeIngredientId = this.db
                  .Products
                  .Where(p => p.Id == productId)
                  .Select(p => p.DrugTypeId)
                  .FirstOrDefault();

            return this.db
                .Products
                .Where(p => p.DrugTypeId == activeIngredientId)
                .Where(p => p.Id != productId)
                .Skip((page - 1) * GlobalConstants.PageItems)
                .Take(GlobalConstants.PageItems)
                .ProjectTo<GenericServiceModel>()
                .OrderBy(gsm => gsm.Price)
                .ToList();
        }

        public int NumOfGenerics(int id)
        {
            var ingredientId = this.db.Products.Where(p => p.Id == id).Select(p => p.DrugTypeId).FirstOrDefault();

            return (this.db.Products.Where(p => p.DrugTypeId == ingredientId).Count() - 1);
        }

        public int NumOfCross(int id)
        {
            var ingredientId = this.db.Products.Where(p => p.Id == id).Select(p => p.DrugTypeId).FirstOrDefault();

            return (this.db.CrossIngredients.Where(ci => ci.CrossId == ingredientId).Count() / 2);
        }
    }
}
