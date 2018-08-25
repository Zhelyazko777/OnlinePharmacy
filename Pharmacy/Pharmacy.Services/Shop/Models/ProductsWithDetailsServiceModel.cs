namespace Pharmacy.Services.Shop.Models
{
    using AutoMapper;
    using Pharmacy.Common.Mapping;
    using Pharmacy.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductsWithDetailsServiceModel: IHaveCustomMapping
    {
        public int ProductId { get; set; }

        public IEnumerable<int> CategoriesIds { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImgName { get; set; }

        public string Description { get; set; }

        public void ConfigureMapping(Profile profile)
        {
            profile
                .CreateMap<Product, ProductsWithDetailsServiceModel>()
                .ForMember(p => p.CategoriesIds, opt => opt.MapFrom(p => p.Categories.Select(c => c.CategoryId)))
                .ForMember(p => p.ProductId, opt => opt.MapFrom(p => p.Id));
        }
    }
}
