using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JewelryManagementApp.Models
{

    // Order Entity
    public class Order
    {
        [Key]
        public int OrderId { get; set; } // Primary Key
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; } // Foreign Key
        [ForeignKey("ShopId")]
        public int ShopId { get; set; } // Foreign Key

        public User? User { get; set; }
        public Shop? Shop { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }

}
