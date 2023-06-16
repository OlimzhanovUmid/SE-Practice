using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Database;

public class AppContext: DbContext
{
    private ConnectionType Type { get; set; } = ConnectionType.Sqlite;
    private string? ConnectionString { get; set; }

    private readonly string _localDbConnectionString =
        @"Server=(localdb)\msSqlLocalDb; Database=cinema; Trusted_Connection = true";

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
        if (Type.Equals(ConnectionType.Sqlite))
        {
            optionsBuilder.UseSqlite(ConnectionString);
        } else if(Type.Equals(ConnectionType.Sqlserver))
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        else
        {
            optionsBuilder.UseSqlServer(_localDbConnectionString);
        }
    }
}