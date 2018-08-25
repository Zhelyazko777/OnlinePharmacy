namespace Pharmacy.Services.Shop.Models
{
    using AutoMapper;
    using Pharmacy.Common.Mapping;
    using Pharmacy.Models;

    public class CartItemModel: IHaveCustomMapping
    {
        public int ProductId { get; set; }

        public string ImgName { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public void ConfigureMapping(Profile profile)
        {
            profile.CreateMap<Product, CartItemModel>()
                .ForMember(cim => cim.ProductId, opt => opt.MapFrom(p => p.Id));
        }
    }
}
