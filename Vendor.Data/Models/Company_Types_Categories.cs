using System.ComponentModel.DataAnnotations;

namespace Vendor.Data.Models
{
    public class Company_Types_Categories
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int CompanyId { get; set; }
        public Company? Company { get; set; }
        [Required]
        public int Category_Id { get; set; }
        [Required]
        public int Type_Id { get; set; }
        public Business_Categories? Category { get; set; }
    }
}
