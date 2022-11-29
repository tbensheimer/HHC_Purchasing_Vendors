using System.ComponentModel.DataAnnotations;

namespace Vendor.Data.Models
{
    public class Business_Categories
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Type_Id { get; set; } = default!;
        public Business_Types? Type { get; set; }
        [Required]
        [StringLength(500)]
        public string? Category_Name { get; set; } = default!;

        public bool Is_Checked { get; set; }

        public List<Company>? Companies { get; set; }
    }
}
