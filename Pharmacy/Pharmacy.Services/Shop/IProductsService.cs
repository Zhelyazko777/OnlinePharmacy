namespace Pharmacy.Services.Shop
{
    using Pharmacy.Services.Shop.Models;
    using System.Collections.Generic;

    public interface IProductsService
    {
        IEnumerable<ProductsServiceModel> All(int page);

        int NumOfProducts();

        int NumOfProductsInCategory(int id);

        ProductsWithDetailsServiceModel ById(int id);

        IEnumerable<ProductsServiceModel> ByCategory(int id, int page);
        
        CartItemModel GetProductInfoForCartById(int id);

        IEnumerable<ProductsDropDownModel> GetProductsDropDown();
    }
}
