namespace Pharmacy.Services.Admin.Models
{
    using Pharmacy.Common.Mapping;
    using Pharmacy.Models;

    public class TypesServiceModel: IMapFrom<DrugIngredient>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
