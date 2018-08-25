namespace Pharmacy.Services.Shop.Models
{
    using Pharmacy.Models;
    using Pharmacy.Common.Mapping;

    public class OrderItemsServiceModel: IMapFrom<OrderItem>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
