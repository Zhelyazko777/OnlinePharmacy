namespace Pharmacy.Services.Shop.Models
{
    using Pharmacy.Models;
    using Pharmacy.Common.Mapping;
    using AutoMapper;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductsServiceModel: IHaveCustomMapping
    {
        public int ProductId { get; set; }

        public IEnumerable<int> CategoriesIds { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImgName { get; set; }

        public void ConfigureMapping(Profile profile)
        {
            profile
                .CreateMap<Product, ProductsServiceModel>()
                .ForMember(p => p.CategoriesIds, opt => opt.MapFrom(p => p.Categories.Select(c => c.CategoryId)))
                .ForMember(p => p.ProductId, opt => opt.MapFrom(p => p.Id));
        }
    }
}
