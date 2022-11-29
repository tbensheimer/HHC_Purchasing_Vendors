using System.ComponentModel.DataAnnotations;

namespace Vendor.Data.Models
{
    public class Account
    {
        [Required]
         public int Id { get; set; }
        [Required]
        public int CompanyId { get; set; }
         public Company? Company { get; set; }
        [Required]
        [RegularExpression(@"^((?!\.)[\w-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W])$", ErrorMessage = "Invalid email address. Format: XXXX@example.com")]
        public string? Email { get; set; } = default!;
        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[^\w\d\s:])([^\s]){6,50}$",
         ErrorMessage = "Password doesn't meet security rules. Password must include at least one: Number, Uppercase Letter, Lowercase Letter, and non-alplha-numeric character. Password Length between 6 and 50 characters (no spaces).")]
        public string? Password { get; set; } = default!;

    }
}
