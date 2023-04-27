using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopArtApp.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string MailAddress{ get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public DateTime DateOfSignIn { get; set; }
        public ICollection<BillAddress>? BillAddresses { get; set; } 
        public ShoppingCart? ShoppingCart { get; set; }
        public ICollection<Command>? Commands { get; set; }

    }
}
