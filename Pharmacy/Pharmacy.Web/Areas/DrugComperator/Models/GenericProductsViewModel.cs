namespace Pharmacy.Web.Areas.DrugComperator.Models
{
    using Pharmacy.Common;
    using Pharmacy.Services.DrugComperator.Models;
    using System.Collections.Generic;

    public class GenericProductsViewModel: ViewModelWithPages
    {
        public IEnumerable<GenericServiceModel> Generics { get; set; }
    }
}
