using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopArtApp.Models
{
    [Table("BillAddresses")]
    public class BillAddress
    {
        [Key]
        public int IdBillAddress { get; set; }

        public User User { get; set; }

        [Required]
        public string County { get; set; }
        [Required]
        public string Town { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public int PostalCode { get; set; }
        public ICollection<Command> Commands { get; set; }
    }
}