namespace Pharmacy.Services.Admin.Models
{
    using AutoMapper;
    using Pharmacy.Common.Mapping;
    using Pharmacy.Models;

    public class DrugTypeServiceModel: IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void ConfigureMapping(Profile profile)
        {
            profile
                .CreateMap<CrossIngredient, DrugTypeServiceModel>()
                .ForMember(dsm => dsm.Name, cfg => cfg.MapFrom(cd => cd.Cross.Name))
                .ForMember(dsm => dsm.Id, cfg => cfg.MapFrom(cd => cd.CrossId));
        }
    }
}
