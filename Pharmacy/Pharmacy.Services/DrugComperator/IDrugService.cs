namespace Pharmacy.Services.DrugComperator
{
    using Pharmacy.Services.Admin.Models;
    using Pharmacy.Services.DrugComperator.Models;
    using System.Collections.Generic;

    public interface IDrugService
    {
        IEnumerable<GenericServiceModel> GenericDrugsById(int productId, int page);

        CrossServiceModel CrossDrugsById(int productId, int page);

        int NumOfGenerics(int id);

        int NumOfCross(int id);
    }
}
