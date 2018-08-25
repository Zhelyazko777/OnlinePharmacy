namespace Pharmacy.Services.Shop.Models
{
    using Pharmacy.Models;
    using Pharmacy.Common.Mapping;
    using AutoMapper;
    using System.Linq;
    using System.Collections.Generic;

    public class CategoriesServiceModel: IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<ChiledCategoriesServiceModel> ChiledCategories { get; set; }

        public bool IsTopCategory { get; set; }

        public void ConfigureMapping(Profile profile)
        {
            profile
                .CreateMap<Category, CategoriesServiceModel>()
                .ForMember(csm => csm.ChiledCategories, opt => opt.MapFrom(c => c.ChiledCategories.Select(cc => new ChiledCategoriesServiceModel { Id = cc.Id, Name = cc.Name }).ToList()));

            profile
                .CreateMap<Category, CategoriesServiceModel>()
                .ForMember(csm => csm.IsTopCategory, opt => opt.MapFrom(c => c.ParentCategory == null ? true : false));
        }
    }
}
