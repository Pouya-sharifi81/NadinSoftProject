using Microsoft.EntityFrameworkCore;
using Nadin.Domain.Model;

namespace Nadin.Infrastucture.Context;

public class NadinContext : DbContext
{
    public NadinContext(DbContextOptions<NadinContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=.;Database=NadinSoftDB;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasIndex(p => new { p.ManufactureEmail, p.ProduceDate })
            .IsUnique();

        base.OnModelCreating(modelBuilder);
    }
}