﻿using System.ComponentModel.DataAnnotations;

namespace Vendor.Data.Models
{
    public class Authorized_Contacts
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int CompanyId { get; set; }
        public Company? Company { get; set; }
        [Required]
        [StringLength(350)]
        public string? FirstName { get; set; } = default!;
        [Required]
        [StringLength(350)]
        public string? LastName { get; set; } = default!;
        [Required]
        [RegularExpression(@"^((?!\.)[\w-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W])$", ErrorMessage = "Invalid email address. Format: XXXX@example.com")]
        public string? Email { get; set; } = default!;
        [Required]
        [RegularExpression(@"^([+]?\d{1,2}[-\s]?|)\d{3}[-\s]?\d{3}[-\s]?\d{4}$", ErrorMessage = "Invalid phone number. Format: XXXXXXXXXX or XXXXXXXXXXX or XXX XXX XXXX or X XXX XXX XXXX")]
        public int? Phone_Number { get; set; }

        public bool Contact_Deleted { get; set; }

        public static List<Authorized_Contacts> Contact = new();

    }
}
