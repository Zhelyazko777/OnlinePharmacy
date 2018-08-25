namespace Pharmacy.Services.Admin.Models
{
    using Pharmacy.Models;
    using Pharmacy.Common.Mapping;

    public class CategoriesAdminServiceModel: IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
