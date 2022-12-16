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
        [RegularExpression(@"^((\d{5}-\d{4})|(\d{5})|([A-Z]\d[A-Z]\s\d[A-Z]\d))$", ErrorMessage = "Invalid Postal Code. Format: XXXXX, XXXXX-XXXX, AXA XAX (Where A is upperCase alphabetic character and X is a numeric digit)")]
        public string? Postal_Code { get; set; }
        [Required]
        [StringLength(350)]
        public string? Country { get; set; } = default!;

    }
}
