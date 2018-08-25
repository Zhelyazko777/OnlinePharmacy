namespace Pharmacy.Web.Areas.Shop.Models
{
    using Pharmacy.Common;
    using Pharmacy.Services.Shop.Models;
    using System.Collections.Generic;

    public class ProductsViewModel: ViewModelWithPages
    {
        public IEnumerable<ProductsServiceModel> Products { get; set; }

        public IEnumerable<CategoriesServiceModel> Categories { get; set; }
    }
}
