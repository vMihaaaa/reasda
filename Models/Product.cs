using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopArtApp.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }

        [ForeignKey("IdCategory")]
        public int? IdCategory { get; set; }
        public string? Description { get; set; }= string.Empty;
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }

        public ICollection<ShoppingCart>? shoppingCarts { get; set; }
        public CommandDetail? CommandDetail { get; set; }
        public ICollection<Category>? Categories { get; set; }

    }
}
