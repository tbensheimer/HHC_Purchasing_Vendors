using System.ComponentModel.DataAnnotations;

namespace Vendor.Data.Models
{
    public class Business_Types
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(500)]
        public string? Type_Name { get; set; } = default!;

        public bool Is_Checked { get; set; }
        public List<Company>? Companies { get; set; }

    }
}
