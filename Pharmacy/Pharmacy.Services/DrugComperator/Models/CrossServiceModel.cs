namespace Pharmacy.Services.DrugComperator.Models
{
    using AutoMapper;
    using Pharmacy.Common.Mapping;
    using Pharmacy.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class CrossServiceModel: IHaveCustomMapping
    {
        public int BaseProductId { get; set; }

        public List<int> Ids { get; set; }

        public List<string> Names { get; set; }

        public List<decimal> Prices { get; set; }
        
        public List<string> ImgNames { get; set; }

        public void ConfigureMapping(Profile profile)
        {
            profile
                .CreateMap<Product, CrossServiceModel>()
                .ForMember(dsm => dsm.BaseProductId, cfg => cfg.MapFrom(p => p.Id))
                .ForMember(dsm => dsm.Ids, cfg => cfg.MapFrom(p => p.DrugType.CrossIngredients.Select(gd => gd.Cross.Products.Select(pr => pr.Id).ToList()).FirstOrDefault()))
                .ForMember(dsm => dsm.Names, cfg => cfg.MapFrom(p => p.DrugType.CrossIngredients.Select(gd => gd.Cross.Products.Select(pr => pr.Name).ToList()).FirstOrDefault()))
                .ForMember(dsm => dsm.Prices, cfg => cfg.MapFrom(p => p.DrugType.CrossIngredients.Select(gd => gd.Cross.Products.Select(pr => pr.Price).ToList()).FirstOrDefault()))
                .ForMember(dsm => dsm.ImgNames, cfg => cfg.MapFrom(p => p.DrugType.CrossIngredients.Select(cd => cd.Cross.Products.Select(pr => pr.ImgName).ToList()).FirstOrDefault()));
            
        }
    }
}
