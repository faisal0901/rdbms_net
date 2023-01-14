using Microsoft.EntityFrameworkCore;
using Tokonyadia.Model;

namespace rdbms_net.repositories;

public class TokonyadiaContext :DbContext
{
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Store> Store { get; set; }
    public DbSet<ProductPrice> ProductPrice { get; set; }
    public DbSet<Product> Product { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString = @"Server=FAISAL;Database=DB_tokonyadia;Trusted_Connection=True;TrustServerCertificate=True;";
        optionsBuilder.UseSqlServer(conString);
    
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Customer>(entity =>
        // {
        //     entity.HasIndex(c => c.email);
        //     entity.HasIndex(c => c.phone_number);
        // });
        // modelBuilder.Entity<Store>(entity =>
        // {
        //     entity.HasIndex(c => c.siup_number);
        //     entity.HasIndex(c => c.phone_number);
        // });

    }

 
}

