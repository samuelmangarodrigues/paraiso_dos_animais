using Microsoft.EntityFrameworkCore;
using ParaisoDosAnimais.Models;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace ParaisoDosAnimais.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.sqlite");
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

            //Relacionamento 1:1 entre Product e Stock ->
            modelBuilder.Entity<Product>()
                .HasOne(p=> p.Stock)
                .WithOne(s=> s.Product)
                .HasForeignKey<Stock>(s => s.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }
}
