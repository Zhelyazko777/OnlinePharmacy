namespace Pharmacy.Services.Admin
{
    using Pharmacy.Models;
    using Pharmacy.Services.Admin.Models;
    using Pharmacy.Services.DrugComperator.Models;
    using System.Collections.Generic;

    public interface ICompareTypesAdminService
    {
        IEnumerable<TypesServiceModel> All(int pages);

        void Add(string name);
            
        bool AddCross(int baseDrugId, int crossDrugId);

        //IEnumerable<DrugTypeServiceModel> CrossDrugTypes(int drugTypeId);

        DrugIngredient GetIngridient(int id);

        bool Update(int id, string name);

        void Delete(int id);
        
        IEnumerable<string> CrossIngredientsById(int id);

        int NumOfIngredients();

        IEnumerable<TypesServiceModel> AllWithoutPages();
    }
}
