using Microsoft.EntityFrameworkCore;
using ShopArtApp.Models;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
               .HasMany(u => u.BillAddresses)
               .WithOne(c => c.User)
               .IsRequired();


            modelBuilder.Entity<User>()
               .HasOne(u => u.ShoppingCart)
               .WithOne(c => c.User)
               .HasForeignKey<ShoppingCart>(e => e.IdShoppingCart)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Command>()
               .HasOne(u => u.User)
               .WithMany(c => c.Commands)
               .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.NoAction);



            modelBuilder.Entity<User>()
            .HasMany(e => e.Commands)
            .WithOne(e => e.User)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Command>()
                .HasOne(c => c.CommandDetail)
                .WithOne(cd => cd.Command)
               .HasForeignKey<CommandDetail>(e => e.IdCommand);

            modelBuilder.Entity<BillAddress>()
             .HasOne(ba => ba.User)
             .WithMany(u => u.BillAddresses);

            modelBuilder.Entity<Category>()
                   .HasMany(e => e.Products)
                   .WithMany(e => e.Categories);

            modelBuilder.Entity<CommandDetail>()
               .HasMany(u => u.Products)
               .WithOne(c => c.CommandDetail)
               .HasForeignKey(e => e.IdProduct);

        }

        public ShopArtAppContext(DbContextOptions<ShopArtAppContext> options) : base(options)
        {

        }



    }
}
