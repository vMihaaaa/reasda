using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopArtApp.Models
{
    [Table("ShoppingCarts")]
    public class ShoppingCart
    {
        [Key]
        public int IdShoppingCart { get; set; }

        [ForeignKey("IdUser")]
        public int? IdUser { get; set; }
        [Required]
        public int Cantity { get; set; }
        [Required]
        public double Total { get; set; }

        [ForeignKey("IdProduct")]
        public int? IdProduct { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
