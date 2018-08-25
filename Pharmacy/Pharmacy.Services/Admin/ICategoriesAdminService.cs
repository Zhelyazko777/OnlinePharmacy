namespace Pharmacy.Services.Admin
{
    using Models;
    using System.Collections.Generic;

    public interface ICategoriesAdminService
    {
        IEnumerable<CategoriesAdminServiceModel> Top();

        IEnumerable<CategoriesAdminServiceModel> Children(int id);

        IEnumerable<CategoriesDropDownModel> GetCategoriesDropDown();

        bool AddChiled(int parentId, int chiledId);

        bool Add(string name);
    }
}
