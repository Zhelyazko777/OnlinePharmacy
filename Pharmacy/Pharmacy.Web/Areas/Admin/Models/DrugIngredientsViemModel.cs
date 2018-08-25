namespace Pharmacy.Web.Areas.Admin.Models
{
    using Pharmacy.Common;
    using Pharmacy.Services.Admin.Models;
    using System.Collections.Generic;

    public class DrugIngredientsViemModel: ViewModelWithPages
    {
        public IEnumerable<TypesServiceModel> DrugIngredients { get; set; }
    }
}
