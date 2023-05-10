using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopArtApp.Models
{
    [Table("ShoppingCarts")]
    public class ShoppingCart
    {
        [Key]
        public int IdShoppingCart { get; set; }
        public User User { get; set; }

        [Required]
        public int Cantity { get; set; }
        [Required]
        public double Total { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
