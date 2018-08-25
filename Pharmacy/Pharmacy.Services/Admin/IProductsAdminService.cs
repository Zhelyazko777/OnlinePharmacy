namespace Pharmacy.Services.Admin
{
    using Microsoft.AspNetCore.Http;
    using Pharmacy.Models;
    using Pharmacy.Services.Admin.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IProductsAdminService
    {
        Task<bool> AddAsync(string name, int categoryId, string description, decimal price, long barcode, int drugTypeId, IFormFile image, string imageName);

        string DeleteProduct(int id);

        Product GetProduct(int id);

        string Update(int id, string name, int categoryId, string description, decimal price, long barcode, int drugTypeId);

        IEnumerable<DrugTypesDropDownModel> GetDrugTypeDropDown();
        
    }
}
