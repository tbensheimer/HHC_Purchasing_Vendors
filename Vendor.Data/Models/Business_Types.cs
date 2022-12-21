using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vendor.Data.Models
{
    public class Business_Types
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(500)]
        public string? Type_Name { get; set; } = default!;
        public List<Company>? Companies { get; set; }
        [NotMapped]
        public bool Is_Checked { get; set; }

    }
}
