using Data.Model;
using Data.Repository;


//Repository.Init(ConnectionType.Sqlite, "Data Source = cinema.db");
/*
Repository.Init(ConnectionType.Sqlserver,
    @"Server=(localdb)\msSqlLocalDb; Database=cinema; Trusted_Connection = true");
*/
Repository.Init(ConnectionType.SqlserverLocaldb);
Repository.EnsureDeleted();
Repository.EnsureCreated();
Seed.Init();

var user = new User
{
    CardCredentials = "1234 5678 9898 7654", 
    FullName = "Olimzhanov Umid", 
    Email = "uolimzhanov@gmail.com",
    PhoneNumber = "+998901234567"
};
Repository.AddUser(user);

var cinemaHall = new CinemaHall
{
    NumberOfSeats = 2,
    Class = "Premium"
};
Repository.AddCinemaHall(cinemaHall);

var session = new Session
{
    CinemaHall = cinemaHall,
    Date = "12.12.2012",
    Time = "21:12",
    MovieName = "A Knives Out Mystery: Glass Onion",
    SessionDuration = 132
};
Repository.AddSession(session);

var order = new Order
{
    Price = 12000,
    Session = session,
    User = user,
    PaymentStatus = true
};
Repository.AddOrder(order);
Repository.SaveChanges();

var toPrint = Repository.PrintOrders();
Console.WriteLine(toPrint);

