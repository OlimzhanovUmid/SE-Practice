using System.Text;
using Data.Database;
using Data.Model;

namespace Data.Repository;

public class CinemaRepository
{
    private CinemaContext Context { get; set; }

    public CinemaRepository(CinemaContext cinemaContext)
    {
        Context = cinemaContext;
    }

    public void EnsureCreated()
    {
        Context.Database.EnsureCreated();
    }

    #region Save

    public int SaveChanges() => Context.SaveChanges();
    public Task<int> SaveChangesAsync() => Context.SaveChangesAsync();
    
    #endregion

    #region AddToBase

    public void AddCinemaHall(CinemaHall entity)
    {
        Context.CinemaHalls.Add(entity);
    }
    
    public void AddCinemaHallsRange(IEnumerable<CinemaHall> entities)
    {
        Context.CinemaHalls.AddRange(entities);
    }
    
    public void AddSession(Session entity)
    {
        Context.Sessions.Add(entity);
    }
    
    public void AddSessionsRange(IEnumerable<Session> entities)
    {
        Context.Sessions.AddRange(entities);
    }
    
    public void AddOrder(Order entity)
    {
        Context.Orders.Add(entity);
    }
    
    public void AddOrdersRange(IEnumerable<Order> entities)
    {
        Context.Orders.AddRange(entities);
    }
    
    public void AddUser(User entity)
    {
        Context.Users.Add(entity);
    }

    public void AddUsersRange(IEnumerable<User> entities)
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

    public CinemaHall? GetCinemaHallById(int id) => Context.CinemaHalls.Find(id);

    public List<CinemaHall> GetCinemaHalls() => Context.CinemaHalls.ToList();

    public Session? GetSessionById(int id) => Context.Sessions.Find(id);

    public List<Session> GetSessions() => Context.Sessions.ToList();

    public User? GetUserById(int id) => Context.Users.Find(id);

    public List<User> GetUsers() => Context.Users.ToList();
    
    public Order? GetOrderById(int id) => Context.Orders.Find(id);

    public List<Order> GetOrders() => Context.Orders.ToList();

    #endregion

    #region Print

    public string PrintCinemaHall(int id)
    {
        var entity = GetCinemaHallById(id);
        return entity != null ? $"{entity.CinemaHallId}. " +
                                $"Number of seats: {entity.NumberOfSeats}, " +
                                $"Class: {entity.Class}" : "Null";
    }

    public string PrintCinemaHalls()
    {
        var stringBuilder = new StringBuilder();
        var entities = Context.CinemaHalls.Select(entity => PrintCinemaHall(entity.CinemaHallId)).ToList();
        foreach (var entity in entities)
            stringBuilder.AppendLine(entity);
        return stringBuilder.ToString();
    }

    public string PrintSession(int id)
    {
        var entity = GetSessionById(id);
        return entity != null ? $"{entity.SessionId}. " +
                                $"Movie name: {entity.MovieName}, " +
                                $"Date: {entity.Date}, " +
                                $"Time: {entity.Time}, " +
                                $"Session duration: {entity.SessionDuration}, " +
                                $"Cinema hall class: {entity.CinemaHall!.Class}" : "Null";
    }
    
    public string PrintSessions()
    {
        var stringBuilder = new StringBuilder();
        var entities = Context.Sessions.Select(entity => PrintSession(entity.SessionId)).ToList();
        foreach (var entity in entities)
            stringBuilder.AppendLine(entity);
        return stringBuilder.ToString();
    }    
    
    public string PrintUser(int id)
    {
        var entity = GetUserById(id);
        return entity != null ? $"{entity.UserId}. " +
                                $"{entity.FullName} - Email: {entity.Email}, " +
                                $"Phone number: {entity.PhoneNumber}, " +
                                $"Card credentials: {entity.CardCredentials}" : "Null";
    }
    
    public string PrintUsers()
    {
        var stringBuilder = new StringBuilder();
        var entities = Context.Sessions.Select(entity => PrintUser(entity.SessionId)).ToList();
        foreach (var entity in entities)
            stringBuilder.AppendLine(entity);
        return stringBuilder.ToString();
    }  
    
    public string PrintOrder(int id)
    {
        var entity = GetOrderById(id);
        return entity != null ? $"{entity.OrderId}. " +
                                $"Movie name: {entity.Session!.MovieName}, " +
                                $"Date: {entity.Session!.Date} at {entity.Session!.Time}, " +
                                $"Cinema hall class: {entity.Session!.CinemaHall!.Class}, " +
                                $"Price: {entity.Price}, " +
                                $"Is paid: {entity.PaymentStatus}" : "Null";
    }
    
    public string PrintOrders()
    {
        var stringBuilder = new StringBuilder();
        var entities = Context.Sessions.Select(entity => PrintOrder(entity.SessionId)).ToList();
        foreach (var entity in entities)
            stringBuilder.AppendLine(entity);
        return stringBuilder.ToString();
    }
    
    #endregion
}
