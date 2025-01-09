using System.ComponentModel.DataAnnotations;

namespace JewelryManagementApp.Models
{
    // Shop Entity
    public class Shop
    {
        [Key]
        public int ShopId { get; set; } // Primary Key
        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? ContactInfo { get; set; }

        public ICollection<Category>? Categories { get; set; }
        public ICollection<Product>? Products { get; set; }
        public ICollection<User>? Users { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }

}
