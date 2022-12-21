using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public List<Company>? Companies { get; set; }
        [NotMapped]
        public bool Is_Checked { get; set; }
    }
}
