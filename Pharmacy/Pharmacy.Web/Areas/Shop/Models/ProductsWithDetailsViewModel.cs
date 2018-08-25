namespace Pharmacy.Web.Areas.Shop.Models
{
    using Pharmacy.Common;
    using Pharmacy.Services.Shop.Models;
    using System.Collections.Generic;

    public class ProductsWithDetailsViewModel: ViewModelWithPages
    {
        public IEnumerable<CategoriesServiceModel> Categories { get; set; }

        public ProductsWithDetailsServiceModel Product { get; set; }
    }
}
