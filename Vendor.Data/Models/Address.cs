using System.ComponentModel.DataAnnotations;

namespace Vendor.Data.Models
{
    public class Address
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int CompanyId { get; set; }
        public Company? Company { get; set; }
        [Required]
        [StringLength(350)]
        public string? Address_1 { get; set; } = default!;
        [StringLength(350)]
        public string? Address_2 { get; set; } = default!;
        [Required]
        [StringLength(350)]
        public string? City { get; set; } = default!;
        [Required]
        public string? State { get; set; } = default!;
        [Required]
        [RegularExpression(@"^[0-9]{5}$|^[0-9]{5}-?[0-9]{4}$", ErrorMessage = "Invalid Postal Code Format. Format: XXXXX or XXXXXXXXX")]
        public int? Postal_Code { get; set; }
        [Required]
        [StringLength(350)]
        public string? Country { get; set; } = default!;

    }
}
