namespace Pharmacy.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User: IdentityUser

    {
        [Required]
        [Range(10, 100)]
        public string Address { get; set; }

        [Required]
        [Range(4, 50)]
        public string FullName { get; set; }

        public IEnumerable<Order> Orders { get; set; }

        [Required]
        public DateTime DateOfRegistration { get; set; }
    }
}
