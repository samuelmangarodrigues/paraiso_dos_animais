using Microsoft.EntityFrameworkCore;
using ParaisoDosAnimais.Models;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace ParaisoDosAnimais.Infrastructure.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<ProductCart> ProductCarts { get; set; }
        public DbSet<Category> Categories { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=app.sqlite");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Relacionamento 1:N entre Client e Address ->
            modelBuilder.Entity<Client>()
                .HasMany(c => c.Addresses)
                .WithOne(a => a.Client)
                .HasForeignKey(a => a.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            //Relacionamento 1:1 entre o Client e Cart ->
            modelBuilder.Entity<Client>()
                .HasOne(cl => cl.Cart)
                .WithOne(ca => ca.Client)
                .HasForeignKey<Cart>(ca => ca.ClientId)
                .OnDelete(DeleteBehavior.Cascade);


            //Relacionamento 1:N entre Product e Category ->
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            //Relacionamento 1:1 entre Product e Stock ->
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Stock)
                .WithOne(s => s.Product)
                .HasForeignKey<Stock>(s => s.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}