using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopArtApp.Models
{
    [Table("Commands")]
    public class Command
    {
        [Key]
        public int IdCommand { get; set; }

        [ForeignKey("IdUser")]
        public string? IdUser { get; set; }
        public string? Status { get; set; }= string.Empty;
        [Required]
        public double Total { get; set; }
        [Required]
        public DateTime DateCommand { get; set; }
        [ForeignKey("IdBillAddress")]
        public string? IdBillAddress { get; set; }
        [ForeignKey("IdCommandDetail")]
        public string? IdCommandDetail { get; set; }
        public User? User { get; set; }
        public BillAddress? BillAddress { get; set; }
        public CommandDetail? CommandDetail { get; set; }
       
    }
}
