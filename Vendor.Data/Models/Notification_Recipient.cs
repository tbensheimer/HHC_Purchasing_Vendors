using System.ComponentModel.DataAnnotations;

namespace Vendor.Data.Models
{
    public class Notification_Recipient
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int NotificationsId { get; set; }
        public Notifications? Notifications { get; set; }
        public int Type_Id { get; set; }
        public Business_Types? Type { get; set; }
        public int Category_Id { get; set; }
        public Business_Categories? Categegory { get; set; }
        [Required]
        public int CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
