namespace Pharmacy.Services.Shop.Models
{
    using Pharmacy.Common.Mapping;
    using Pharmacy.Models;

    public class ProductsDropDownModel: IMapFrom<Product>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
