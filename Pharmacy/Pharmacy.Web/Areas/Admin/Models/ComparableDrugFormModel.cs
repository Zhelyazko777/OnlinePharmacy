namespace Pharmacy.Web.Areas.Admin.Models
{
    using Microsoft.AspNetCore.Mvc;

    public class ComparableDrugFormModel
    {
        [FromBody]
        public int ComparableDrugId { get; set; }

        [FromRoute]
        public int Id { get; set; }
    }
}
