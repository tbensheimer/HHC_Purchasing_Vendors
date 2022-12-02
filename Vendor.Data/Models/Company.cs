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
        //  [RegularExpression(@"^(?!123([ -]?)45([ -]?)6789)(?!\b(\d)\3+\b)(?!000|666|900|999)[0-9]{3}([ -]?)(?!00)[0-9]{2}\4(?!0000)[0-9]{4}$", ErrorMessage = "Invalid SSN, please follow the format: XXX-XX-XXXX, XXXXXXXXX, XXX XX XXXX")]
        //    [RegularExpression(@"^((?!11-1111111)(?!22-2222222)(?!33-3333333)(?!44-4444444)(?!55-5555555)(?!66-6666666)(?!77-7777777)(?!88-8888888)(?!99-9999999)(?!12-3456789)(?!00-[0-9]{7})([0-9]{2}-[0-9]{7}))*$", ErrorMessage = "Invalid Federal Tax Id, please follow the format: XX-XXXXXXX")]
        [RegularExpression(@"^(\d{9})|(^\d{3}-\d{2}-\d{4}$)|(^[1-9]\d?-\d{7})$", ErrorMessage = "Invalid SSN or Federal Tax Id: Please follow the accepted formats: XXXXXXXXX (no dashes)")]
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
