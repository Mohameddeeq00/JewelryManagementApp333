using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JewelryManagementApp.Models
{

    // Product Entity
    // Product Entity
    public class Product
    {
        [Key]
        public int ProductId { get; set; } // Primary Key
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; } // Foreign Key
        [ForeignKey("ShopId")]
        public int ShopId { get; set; } // Foreign Key

        public Category? Category { get; set; }
        public Shop? Shop { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
