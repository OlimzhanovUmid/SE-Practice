using App.Model;
using Microsoft.EntityFrameworkCore;

namespace App.Database;

public class CinemaContext: DbContext
{
    private ConnectionType Type { get; set; } = ConnectionType.Sqlite;
    private string? ConnectionString { get; set; }

    public CinemaContext(string newConnectionString)
    {
        ConnectionString = newConnectionString;
    }
    public CinemaContext(ConnectionType newType, string newConnectionString)
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
        } else
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}