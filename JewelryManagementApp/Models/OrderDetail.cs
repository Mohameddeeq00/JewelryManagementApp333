using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JewelryManagementApp.Models
{

    // OrderDetail Entity
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; } // Primary Key
        [ForeignKey("OrderId")]
        public int OrderId { get; set; } // Foreign Key
        [ForeignKey("ProductId")]
        public int ProductId { get; set; } // Foreign Key
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public Order? Order { get; set; }
        public Product? Product { get; set; }

    }  }
