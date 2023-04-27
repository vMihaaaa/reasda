using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopArtApp.Models
{
    [Table("CommandDetails")]
    public class CommandDetail
    {
        [Key]
        public int IdCommandDetail { get; set; }

        [ForeignKey("IdCommand")]
        public string? IdCommand { get; set; }
        [Required]
        public int Cantity { get; set; }
        [Required]
        public double UnitPrice { get; set; }

        public ICollection<Product>? Products { get; set; }


    }
}

