namespace Pharmacy.Web.Areas.Admin.Models
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class ProductFormModel
    {
        [DisplayName("Име")]
        [StringLength(50, ErrorMessage = "Името трябва да е до 50 символа!")]
        public string Name { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }

        [DisplayName("Цена")]
        [Range(0, double.MaxValue, ErrorMessage = "Много голяма цена!")]
        public decimal Price { get; set; }

        [Range(0, long.MaxValue, ErrorMessage = "Прекалено дълъг баркод!")]
        [DisplayName("Баркод")]
        public long Barcode { get; set; }

        [DisplayName("Лекарствен тип")]
        public int DrugTypeId { get; set; }

        public IEnumerable<SelectListItem> DrugTypes { get; set; }

        [DisplayName("Категория")]
        public int CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }

        [DisplayName("Снимка")]
        public IFormFile Image { get; set; }
    }
}
