namespace Pharmacy.Services.DrugComperator.Models
{
    using Pharmacy.Models;
    using Pharmacy.Common.Mapping;

    public class GenericServiceModel: IMapFrom<Product>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImgName { get; set; }
    }
}
