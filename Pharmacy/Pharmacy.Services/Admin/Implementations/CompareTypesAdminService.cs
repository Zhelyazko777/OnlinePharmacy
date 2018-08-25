namespace Pharmacy.Services.Admin.Implementations
{
    using AutoMapper.QueryableExtensions;
    using Pharmacy.Common;
    using Pharmacy.Data;
    using Pharmacy.Models;
    using Pharmacy.Services.Admin.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class CompareTypesAdminService : ICompareTypesAdminService
    {
        private readonly PharmacyDbContext db;

        public CompareTypesAdminService(PharmacyDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<TypesServiceModel> All(int page)
            => this.db
                .DrugIngredients
                .Skip((page - 1) * GlobalConstants.PageItems)
                .Take(GlobalConstants.PageItems)
                .ProjectTo<TypesServiceModel>()
                .OrderBy(tsm => tsm.Name)
                .ToList();

        public IEnumerable<TypesServiceModel> AllWithoutPages()
            => this.db
                .DrugIngredients
                .ProjectTo<TypesServiceModel>()
                .ToList();

        public void Add(string name)
        {
            this.db.DrugIngredients.Add(new DrugIngredient { Name = name });

            this.db.SaveChanges();
        }

        public bool AddCross(int baseDrugId, int crossDrugId)
        {
            var baseIngredient = this.db.DrugIngredients.Where(di => di.Id == baseDrugId).Select(di => di.Name).FirstOrDefault();
            var crossIngredient = this.db.DrugIngredients.Where(di => di.Id == crossDrugId).Select(di => di.Name).FirstOrDefault();

            if (baseIngredient == null || crossIngredient == null)
            {
                return false;
            }

            this.db
                .CrossIngredients
                .Add(new CrossIngredient
                {
                    DrugIngredientId = baseDrugId,
                    CrossId = crossDrugId
                });

            this.db
                .CrossIngredients
                .Add(new CrossIngredient
                {
                    DrugIngredientId = crossDrugId,
                    CrossId = baseDrugId
                });

            this.db.SaveChanges();
            return true;
        }

        //public IEnumerable<DrugTypeServiceModel> CrossDrugTypes(int drugTypeId)
        //    => this.db
        //            .CrossIngredients
        //            .Where(cd => cd.DrugIngredientId == drugTypeId)
        //            .ProjectTo<DrugTypeServiceModel>()
        //            .OrderBy(dtsm => dtsm.Name)
        //            .ToList();

        public void Delete(int id)
        {
            var ingredient = this.db.DrugIngredients.Find(id);
            this.db.DrugIngredients.Remove(ingredient);
            this.db.SaveChanges();
        }

        public DrugIngredient GetIngridient(int id)
            => this.db.DrugIngredients.Find(id);

        public bool Update(int id, string name)
        {
            var ingredient = this.db.DrugIngredients.Where(di => di.Id == id).FirstOrDefault();
            if (ingredient == null)
            {
                return false;
            }

            ingredient.Name = name;
            this.db.DrugIngredients.Update(ingredient);
            this.db.SaveChanges();

            return true;
        }

        public IEnumerable<string> CrossIngredientsById(int id)
            => this.db
                .DrugIngredients
                .Where(dt => dt.Id == id)
                .Select(dt => dt.CrossIngredients.Select(ci => ci.Cross.Name).OrderBy(n => n))
                .FirstOrDefault();

        public int NumOfIngredients()
            => this.db.DrugIngredients.Count();
    }
}
