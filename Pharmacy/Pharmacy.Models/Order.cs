namespace Pharmacy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Order
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public DateTime DateOfOrdering { get; set; } 

        public IEnumerable<OrderItem> Items { get; set; } = new HashSet<OrderItem>();

        [Required]
        [Range(0, Double.MaxValue)]
        public decimal FinalSum { get; set; }

        public bool IsRead { get; set; }
    }
}
