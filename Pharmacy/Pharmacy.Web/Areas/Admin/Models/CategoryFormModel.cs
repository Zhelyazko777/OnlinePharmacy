namespace Pharmacy.Web.Areas.Admin.Models
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class CategoryFormModel
    {
        [DisplayName("Име")]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }

        [DisplayName("Родителска категория")]
        public int? ParentId { get; set; }
        
        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}
