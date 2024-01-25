using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data;

public class DatabaseContext: DbContext
{
    public DbSet<Comanda> Comenzi { get; set; }   
    public DbSet<Produs> Produse { get; set; }
    public DbSet<ComandaProdusRelatie> ComandaProdusRelatii { get; set; }
    public DbSet<Utilizator> Utilizatori { get; set; }
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Relatie Utilizator - Comenzi
        modelBuilder.Entity<Utilizator>()
            .HasMany(u => u.Comenzi)
            .WithOne(c => c.Utilizator)
            .HasForeignKey(src => src.UtilizatorId)
            .OnDelete(DeleteBehavior.Cascade);
        
        // Relatie Comenzi - ComandaProdus - Produs
        modelBuilder.Entity<ComandaProdusRelatie>().HasKey(src => src.Id);

        modelBuilder.Entity<Comanda>()
            .HasMany(c => c.Produse)
            .WithOne(p => p.Comanda)
            .HasForeignKey(src => src.ComandaId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Produs>()
            .HasMany(p => p.Comenzi)
            .WithOne(c => c.Produs)
            .HasForeignKey(src => src.ProdusId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}