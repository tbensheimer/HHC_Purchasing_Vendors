using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendor.Data.Models
{
    public class Company
    {
        [Required]

        public int Id { get; set; }
        [Required]
        [StringLength(350)]
        public string Name { get; set; } = default!;
        [Required]
        public DateTime Sign_Up { get; set; }
        [Required]
       /// What about Fed ID ????    [RegularExpression(@"^(?!(000|666|9))\d{3}-(?!00)\d{2}-(?!0000)\d{4}$", ErrorMessage = "Invalid SSN, No dashes")]
        public int? Fed_Id_SSN { get; set; }
        [Required]
        public string Supplier_Category { get; set; } = default!;
        
        public string? Website { get; set; } = default!;
        [Required]
        public string Diversity_Certification { get; set; } = default!;
        public string? Other_Diversity_Certification { get; set; } = default!;
        [Required]
        [StringLength(500)]
        public string Description_Goods_Services { get; set; } = default!;
        public bool Disabled_From_Notifications { get; set; }

        public bool Is_Deleted { get; set; }

        public bool Is_Checked { get; set; }


    }

}
