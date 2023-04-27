using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using ShopArtApp.Models;
using System.Reflection.Metadata;

namespace ShopArtApp.DataAcces.Context
{
    public class ShopArtAppContext : DbContext
    {
        public DbSet<BillAddress> BillAddresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Command> Commands { get; set; }
        public DbSet<CommandDetail> CommandsDetail { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<User> Users { get; set; }

        public ShopArtAppContext(DbContextOptions<ShopArtAppContext> options) : base(options)
        {

        }


      
    }
}
