namespace Pharmacy.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class DrugIngredient
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Името трябва да е до 50 символа!")]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; } = new HashSet<Product>();

        public ICollection<CrossIngredient> CrossOf { get; set; } = new HashSet<CrossIngredient>();
        public ICollection<CrossIngredient> CrossIngredients { get; set; } = new HashSet<CrossIngredient>();
    }
}
