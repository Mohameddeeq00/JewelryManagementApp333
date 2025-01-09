using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JewelryManagementApp.Models
{
    // Category Entity
    public class Category
    {
        [Key]
        public int CategoryId { get; set; } // Primary Key
        public string? Name { get; set; }
        [ForeignKey("ShopId")]
        public int ShopId { get; set; } // Foreign Key

        public Shop? Shop { get; set; }
        public ICollection<Product>? Products { get; set; }
    }

}
