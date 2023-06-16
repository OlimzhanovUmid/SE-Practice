using System.Text;
using Data.Database;
using Data.Model;

namespace Data.Repository;

public class Repository
{
    private static CinemaContext Context { get; set; } = null!;

    public Repository(ConnectionType connectionType, string connectionString)
    {
        Context = CinemaContextContainer.Init(connectionType, connectionString)!;
    }

    public static void EnsureCreated()
    {
        Context.Database.EnsureCreated();
    }
    public static void EnsureDeleted()
    {
        Context.Database.EnsureDeleted();
    }

    #region Save

    public static int SaveChanges() => Context.SaveChanges();
    public static Task<int> SaveChangesAsync() => Context.SaveChangesAsync();
    
    #endregion

    #region AddToBase

    public static void AddCinemaHall(CinemaHall entity)
    {
        Context.CinemaHalls.Add(entity);
    }
    
    public static void AddCinemaHallsRange(IEnumerable<CinemaHall> entities)
    {
        Context.CinemaHalls.AddRange(entities);
    }
    
    public static void AddSession(Session entity)
    {
        Context.Sessions.Add(entity);
    }
    
    public static void AddSessionsRange(IEnumerable<Session> entities)
    {
        Context.Sessions.AddRange(entities);
    }
    
    public static void AddOrder(Order entity)
    {
        Context.Orders.Add(entity);
    }
    
    public static void AddOrdersRange(IEnumerable<Order> entities)
    {
        Context.Orders.AddRange(entities);
    }
    
    public static void AddUser(User entity)
    {
        Context.Users.Add(entity);
    }

    public static void AddUsersRange(IEnumerable<User> entities)
    {
        Context.Users.AddRange(entities);
    }
    
    #endregion

    #region RemoveFromBase
    
    public void RemoveCinemaHall(CinemaHall entity)
    {
        Context.CinemaHalls.Remove(entity);
    }
    
    public void RemoveCinemaHallsRange(IEnumerable<CinemaHall> entities)
    {
        Context.CinemaHalls.RemoveRange(entities);
    }
    
    public void RemoveSession(Session entity)
    {
        Context.Sessions.Remove(entity);
    }
    
    public void RemoveSessionsRange(IEnumerable<Session> entities)
    {
        Context.Sessions.RemoveRange(entities);
    }
    
    public void RemoveOrder(Order entity)
    {
        Context.Orders.Remove(entity);
    }
    
    public void RemoveOrdersRange(IEnumerable<Order> entities)
    {
        Context.Orders.RemoveRange(entities);
    }
    
    public void RemoveUser(User entity)
    {
        Context.Users.Remove(entity);
    }

    public void RemoveUsersRange(IEnumerable<User> entities)
    {
        Context.Users.RemoveRange(entities);
    }

    #endregion

    #region GetFromBase

    public static CinemaHall? GetCinemaHallById(int id) => Context.CinemaHalls.Find(id);

    public static IEnumerable<CinemaHall> GetCinemaHalls() => Context.CinemaHalls.ToList();

    public static Session? GetSessionById(int id) => Context.Sessions.Find(id);

    public static IEnumerable<Session> GetSessions() => Context.Sessions.ToList();

    public static User? GetUserById(int id) => Context.Users.Find(id);

    public static IEnumerable<User> GetUsers() => Context.Users.ToList();
    
    public static Order? GetOrderById(int id) => Context.Orders.Find(id);

    public static IEnumerable<Order> GetOrders() => Context.Orders.ToList();

    #endregion

    #region Print

    public static string PrintCinemaHall(int id)
    {
        var entity = GetCinemaHallById(id);
        return entity != null ? $"{entity.CinemaHallId}. " +
                                $"Number of seats: {entity.NumberOfSeats}, " +
                                $"Class: {entity.Class}" : "Null";
    }

    public static string PrintCinemaHalls()
    {
        var stringBuilder = new StringBuilder();
        var entities = GetCinemaHalls().Select(entity => PrintCinemaHall(entity.CinemaHallId)).ToList();
        foreach (var entity in entities)
            stringBuilder.AppendLine(entity);
        return stringBuilder.ToString();
    }

    public static string PrintSession(int id)
    {
        var entity = GetSessionById(id);
        return entity != null ? $"{entity.SessionId}. " +
                                $"Movie name: {entity.MovieName}, " +
                                $"Date: {entity.Date}, " +
                                $"Time: {entity.Time}, " +
                                $"Session duration: {entity.SessionDuration}, " +
                                $"Cinema hall class: {entity.CinemaHall!.Class}" : "Null";
    }
    
    public static string PrintSessions()
    {
        var stringBuilder = new StringBuilder();
        var entities = GetSessions().Select(entity => PrintSession(entity.SessionId)).ToList();
        foreach (var entity in entities)
            stringBuilder.AppendLine(entity);
        return stringBuilder.ToString();
    }    
    
    public static string PrintUser(int id)
    {
        var entity = GetUserById(id);
        return entity != null ? $"{entity.UserId}. " +
                                $"{entity.FullName} - Email: {entity.Email}, " +
                                $"Phone number: {entity.PhoneNumber}, " +
                                $"Card credentials: {entity.CardCredentials}" : "Null";
    }
    
    public static string PrintUsers()
    {
        var stringBuilder = new StringBuilder();
        var entities = GetUsers().Select(entity => PrintUser(entity.UserId)).ToList();
        foreach (var entity in entities)
            stringBuilder.AppendLine(entity);
        return stringBuilder.ToString();
    }  
    
    public static string PrintOrder(int id)
    {
        var entity = GetOrderById(id);
        return entity != null ? $"{entity.OrderId}. " +
                                $"Movie name: {entity.Session!.MovieName}, " +
                                $"Date: {entity.Session!.Date} at {entity.Session!.Time}, " +
                                $"Cinema hall class: {entity.Session!.CinemaHall!.Class}, " +
                                $"Price: {entity.Price}, " +
                                $"Is paid: {entity.PaymentStatus}" : "Null";
    }
    
    public static string PrintOrders()
    {
        var stringBuilder = new StringBuilder();
        var entities = GetOrders().Select(entity => PrintOrder(entity.SessionId)).ToList();
        foreach (var entity in entities)
            stringBuilder.AppendLine(entity);
        return stringBuilder.ToString();
    }
    
    #endregion
}
