using System.Text;
using Data.Database;
using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository;

public static class Repository
{
    private static CinemaContext Context { get; set; } = null!;

    public static void Init(ConnectionType connectionType, string connectionString)
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
    
    public static void RemoveCinemaHall(CinemaHall entity)
    {
        Context.CinemaHalls.Remove(entity);
    }
    
    public static void RemoveCinemaHallsRange(IEnumerable<CinemaHall> entities)
    {
        Context.CinemaHalls.RemoveRange(entities);
    }
    
    public static void RemoveSession(Session entity)
    {
        Context.Sessions.Remove(entity);
    }
    
    public static void RemoveSessionsRange(IEnumerable<Session> entities)
    {
        Context.Sessions.RemoveRange(entities);
    }
    
    public static void RemoveOrder(Order entity)
    {
        Context.Orders.Remove(entity);
    }
    
    public static void RemoveOrdersRange(IEnumerable<Order> entities)
    {
        Context.Orders.RemoveRange(entities);
    }
    
    public static void RemoveUser(User entity)
    {
        Context.Users.Remove(entity);
    }

    public static void RemoveUsersRange(IEnumerable<User> entities)
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

    public static string PrintCinemaHalls(IEnumerable<CinemaHall> cinemaHalls)
    {
        var stringBuilder = new StringBuilder();
        var entities = cinemaHalls.Select(entity => PrintCinemaHall(entity.CinemaHallId)).ToList();
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
    public static string PrintSessions(IEnumerable<Session> sessions)
    {
        var stringBuilder = new StringBuilder();
        var entities = sessions.Select(entity => PrintSession(entity.SessionId)).ToList();
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
    public static string PrintUsers(IEnumerable<User> users)
    {
        var stringBuilder = new StringBuilder();
        var entities = users.Select(entity => PrintUser(entity.UserId)).ToList();
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
    
    public static string PrintOrders(IEnumerable<Order> orders)
    {
        var stringBuilder = new StringBuilder();
        var entities = orders.Select(entity => PrintOrder(entity.SessionId)).ToList();
        foreach (var entity in entities)
            stringBuilder.AppendLine(entity);
        return stringBuilder.ToString();
    }
    
    #endregion
    
    public static class Linq
    {
        public static IEnumerable<User> GetUsersWhoDidNotPay() => (from orders in Context.Orders.Include(u => u.User)
            where orders.PaymentStatus == false
            select orders.User).ToList();

        public static IEnumerable<Order> GetOrdersCheaperThan(int price) =>
            (from orders in Context.Orders where orders.Price <= price select orders).ToList();

        public static IEnumerable<CinemaHall> GetHallsWithXSeats(int x) =>
            (from halls in Context.CinemaHalls where halls.NumberOfSeats == x select halls).ToList();

        public static IEnumerable<Session> GetMovieWithDurationMoreThan(int duration) =>
            (from sessions in Context.Sessions where sessions.SessionDuration >= duration select sessions).ToList();
        
        public static IEnumerable<Session> GetMovieWithDurationLessThan(int duration) =>
            (from sessions in Context.Sessions where sessions.SessionDuration <= duration select sessions).ToList();
    }
    
    public static class SqlRaw
    {
        public static IEnumerable<User> GetUsersWhoNameLike(string scratch) => Context.Users.FromSqlRaw($"SELECT * FROM Users WHERE FullName LIKE %{scratch}%").ToList();

        public static IEnumerable<Order> GetOrdersCheaperThan(int price) => Context.Orders.FromSqlRaw($"SELECT * FROM Orders WHERE Price >= {price}").ToList();

        public static IEnumerable<CinemaHall> GetHallsWithXSeats(int x) =>
            Context.CinemaHalls.FromSqlRaw($"SELECT * FROM CinemaHalls WHERE NumberOfSeats = {x}");

        public static IEnumerable<Session> GetMovieWithDurationMoreThan(int duration) =>
            Context.Sessions.FromSqlRaw($"SELECT * FROM Sessions WHERE SessionDuration >= ${duration}");
        
        public static IEnumerable<Session> GetMovieWithDurationLessThan(int duration) => 
            Context.Sessions.FromSqlRaw($"SELECT * FROM Sessions WHERE SessionDuration <= ${duration}");
    }
}
