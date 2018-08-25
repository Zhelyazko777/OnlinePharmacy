using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Името трябва да е до 50 символа!")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Много голяма цена!")]
        public decimal Price { get; set; }

        public int DrugTypeId { get; set; }

        public DrugIngredient DrugType { get; set; }

        //[Range(0, double.MaxValue, ErrorMessage = "Много голяма цифра!")]
        //public decimal Discount { get; set; }

        public DateTime AddDate { get; set; } = new DateTime();

        [Range(0, long.MaxValue, ErrorMessage = "Прекалено дълъг баркод!")]
        public long Barcode { get; set; }

        public IEnumerable<ProductsCategories> Categories { get; set; } = new HashSet<ProductsCategories>();

        public string ImgName { get; set; }
    }
}
