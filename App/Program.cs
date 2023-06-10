// See https://aka.ms/new-console-template for more information

using Data.Database;
using Data.Model;
using Data.Repository;

using var context = new CinemaContext(ConnectionType.Sqlite, "Data Source = cinema.db");

var repository = new CinemaRepository(context);
repository.EnsureCreated();

var user = new User
{
    CardCredentials = "1234 5678 9898 7654", 
    FullName = "Olimzhanov Umid", 
    Email = "uolimzhanov@gmail.com",
    PhoneNumber = "+998901234567"
};
repository.AddUser(user);

var cinemaHall = new CinemaHall
{
    NumberOfSeats = 2,
    Class = "Premium"
};
repository.AddCinemaHall(cinemaHall);

var session = new Session
{
    CinemaHall = cinemaHall,
    Date = "12.12.2012",
    Time = "21:12",
    MovieName = "A Knives Out Mystery: Glass Onion",
    SessionDuration = 132
};
repository.AddSession(session);

var order = new Order
{
    Price = 12000,
    Session = session,
    User = user,
    PaymentStatus = true
};
repository.AddOrder(order);

var toPrint = repository.PrintOrders();
Console.WriteLine(toPrint);

repository.SaveChanges();