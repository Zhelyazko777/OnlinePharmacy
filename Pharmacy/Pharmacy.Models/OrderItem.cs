namespace Pharmacy.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class OrderItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Името трябва да е до 50 символа!")]
        public string Name { get; set; }

        [Required]
        [Range(1, 1000)]
        public int Quantity { get; set; }
        
        [Required]
        [Range(0, Double.MaxValue)]
        public decimal Price { get; set; }
        
        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}
