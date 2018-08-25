namespace Pharmacy.Web.Areas.DrugComperator.Models
{
    using Pharmacy.Common;
    using Pharmacy.Services.DrugComperator.Models;
    using System.Collections.Generic;

    public class CrossDrugsViewModel: ViewModelWithPages
    {
        public CrossServiceModel CrossDrugs { get; set; }
    }
}
