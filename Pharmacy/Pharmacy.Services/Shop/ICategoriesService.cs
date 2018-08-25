namespace Pharmacy.Services.Shop
{
    using Pharmacy.Services.Shop.Models;
    using System.Collections.Generic;

    public interface ICategoriesService
    {
        //IEnumerable<CategoriesServiceModel> TopParents();

        //IEnumerable<CategoriesServiceModel> Children(int parentId);

        IEnumerable<CategoriesServiceModel> All();

        bool IsCatgoryExists(int id);
    }
}
