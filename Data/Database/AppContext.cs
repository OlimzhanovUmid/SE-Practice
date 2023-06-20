using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Database;

public class AppContext: DbContext
{
    private static AppContext? _context;
    private ConnectionType Type { get; set; } = ConnectionType.Sqlite;
    private string? ConnString { get; set; }

    private const string LocalDbConnectionString 
        = @"Server=(localdb)\msSqlLocalDb; Database=cinema; Trusted_Connection = true";

    #region Private constructors

    private AppContext(string newConnString) { ConnString = newConnString; }

    private AppContext(ConnectionType newType) { Type = newType; }

    private AppContext(ConnectionType newType, string newConnString) { 
        Type = newType; 
        ConnString = newConnString;
    }

    #endregion

    #region DbSets

    public DbSet<CinemaHall> CinemaHalls { get; set; } = null!;
    public DbSet<Session> Sessions { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    
    #endregion

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        switch (Type)
        {
            case ConnectionType.Sqlite:
                optionsBuilder.UseSqlite(ConnString);
                break;
            case ConnectionType.Sqlserver:
                optionsBuilder.UseSqlServer(ConnString);
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

        modelBuilder.Entity<Order>().HasOne(s => s.Session);
        modelBuilder.Entity<Order>().HasOne(u => u.User);
    }
    
    public static AppContext 
        Init(ConnectionType type,
            string connectionString) => _context ??= new AppContext(type, connectionString);

    public static AppContext 
        Init(ConnectionType type) => _context ??= new AppContext(type);
}