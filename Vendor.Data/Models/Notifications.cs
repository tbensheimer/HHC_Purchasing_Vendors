using System.ComponentModel.DataAnnotations;

namespace Vendor.Data.Models
{
    public class Notifications
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(500)]
        public string? Title { get; set; } = default!;
        [Required]
        public string? Body { get; set; } = default!;
        [Required]
        public DateTime Date_Sent { get; set; }

        [StringLength(300)]
        public string? Created_By { get; set; } = default!;
        public bool? Reoccuring_Notification { get; set; }
        public int? Days_Reoccuring { get; set; }
    }
}
