using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopArtApp.Models
{
    [Table("BillAddresses")]
    public class BillAddress
    {
        [Key]
        public int IdBillAddress { get; set; }

        [ForeignKey("IdUser")]
        public int? IdUser { get; set; }
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
        public User? User { get; set; }
    }
}
