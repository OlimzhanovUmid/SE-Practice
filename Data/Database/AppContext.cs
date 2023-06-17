using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Database;

public class AppContext: DbContext
{
    private ConnectionType Type { get; set; } = ConnectionType.Sqlite;
    private string? ConnectionString { get; set; }

    private const string LocalDbConnectionString = @"Server=(localdb)\msSqlLocalDb; Database=cinema; Trusted_Connection = true";

    public AppContext(string newConnectionString)
    {
        ConnectionString = newConnectionString;
    }
    public AppContext(ConnectionType newType)
    {
        Type = newType;
    }
    public AppContext(ConnectionType newType, string newConnectionString)
    {
        Type = newType;
        ConnectionString = newConnectionString;
    }
    
    public DbSet<CinemaHall> CinemaHalls { get; set; } = null!;
    public DbSet<Session> Sessions { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        switch (Type)
        {
            case ConnectionType.Sqlite:
                optionsBuilder.UseSqlite(ConnectionString);
                break;
            case ConnectionType.Sqlserver:
                optionsBuilder.UseSqlServer(ConnectionString);
                break;
            case ConnectionType.SqlserverLocaldb:
            default:
                optionsBuilder.UseSqlServer(LocalDbConnectionString);
                break;
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>()
            .Property(u => u.CardCredentials)
            .HasMaxLength(19);
        modelBuilder.Entity<User>()
            .Property(u => u.PhoneNumber)
            .HasMaxLength(13).IsFixedLength();
    }
}