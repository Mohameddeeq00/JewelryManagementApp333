using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JewelryManagementApp.Models
{

    // User Entity
    public class User : IdentityUser
    {
        [Key]
        public int UserId { get; set; } // Primary Key
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        [ForeignKey("ShopId")]
        public int ShopId { get; set; } // Foreign Key

        public Shop? Shop { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }

}
