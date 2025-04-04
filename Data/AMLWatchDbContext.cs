using Microsoft.EntityFrameworkCore;
using AMLWatch.Models;

namespace AMLWatch.Data;

public class AMLWatchDbContext : DbContext
{
    public AMLWatchDbContext(DbContextOptions<AMLWatchDbContext> options) : base(options) { }
    public DbSet<Client> Clients => Set<Client>();
    public DbSet<Transaction> Transactions => Set<Transaction>();
    public DbSet<Alert> Alerts => Set<Alert>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Un client peut avoir plusieurs transactions
        modelBuilder.Entity<Client>()
            .HasMany(c => c.Transactions)         // Navigation vers Transactions
            .WithOne(t => t.Client)              // Inverse : chaque Transaction a un Client
            .HasForeignKey(t => t.ClientId);     // FK dans Transaction → ClientId

        // Une alerte est liée à un client
        modelBuilder.Entity<Alert>()
            .HasOne(a => a.Client)               // Chaque alerte a 1 client
            .WithMany()                          // Le client peut avoir 0..n alertes (non navigable ici)
            .HasForeignKey(a => a.ClientId);     // FK dans Alert → ClientId
    }
}