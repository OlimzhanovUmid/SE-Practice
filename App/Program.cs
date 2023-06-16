// See https://aka.ms/new-console-template for more information


using App.Database;
using App.Model;

using var context = new CinemaContext(ConnectionType.Sqlite, "Data Source = cinema.db");
context.Database.EnsureDeleted();
context.Database.EnsureCreated();

var user = new User
{
    CardCredentials = "1234 5678 9898 7654", 
    FullName = "Olimzhanov Umid", 
    Email = "uolimzhanov@gmail.com",
    PhoneNumber = "+998901234567"
};
context.Users.Add(user);

var cinemaHall = new CinemaHall
{
    NumberOfSeats = 2,
    Class = "Premium"
};
context.CinemaHalls.Add(cinemaHall);

var session = new Session
{
    CinemaHall = cinemaHall,
    Date = "12.12.2012",
    Time = "21:12",
    MovieName = "A Knives Out Mystery: Glass Onion",
    SessionDuration = 132
};
context.Sessions.Add(session);

var order = new Order
{
    Price = 12000,
    Session = session,
    User = user,
    PaymentStatus = true
};
context.Orders.Add(order);
context.SaveChanges();

var entities = context.Orders.ToList();
foreach (var entity in entities)
{
    Console.WriteLine($"{entity.OrderId}. " +
                      $"Movie name: {entity.Session!.MovieName}, " +
                      $"Date: {entity.Session!.Date} at {entity.Session!.Time}, " +
                      $"Cinema hall class: {entity.Session!.CinemaHall!.Class}, " +
                      $"Price: {entity.Price}, " +
                      $"Is paid: {entity.PaymentStatus}");
}
Console.WriteLine();

