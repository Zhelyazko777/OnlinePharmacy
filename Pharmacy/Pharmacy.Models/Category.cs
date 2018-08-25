namespace Pharmacy.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }

        public int? ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }

        public ICollection<Category> ChiledCategories { get; set; } = new HashSet<Category>();

        public IEnumerable<ProductsCategories> Products { get; set; } = new HashSet<ProductsCategories>();
    }
}
