using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopArtApp.Models
{
    [Table("CommandDetails")]
    public class CommandDetail
    {
        [Key]
        public int IdCommandDetail { get; set; }
        public int IdCommand { get; set; }
        public Command? Command { get; set; }
        [Required]
        public int Cantity { get; set; }
        [Required]
        public double UnitPrice { get; set; }

        public ICollection<Product>? Products { get; set; }


    }
}

