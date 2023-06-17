using Data.Model;
using Data.Repository;

Console.WriteLine("Choose connection type:");
Console.WriteLine("1. Sqlite\n2. Sql Server\n3. Sql Server LocalDb");
Console.Write("Input connection type:");
var userInput = Console.ReadLine();
switch (userInput)
{
    case "1":
        Repository.Init(ConnectionType.Sqlite, "Data Source = cinema.db");
        Thread.Sleep(1000);
        Console.WriteLine("You have chosen: Sqlite");
        break;
    case "2":
        Repository.Init(ConnectionType.Sqlserver,
            @"Server=(localdb)\msSqlLocalDb; Database=cinema; Trusted_Connection = true");
        Thread.Sleep(1000);
        Console.WriteLine("You have chosen: Sql Server");
        break;
    case "3":
        Repository.Init(ConnectionType.SqlserverLocaldb);
        Thread.Sleep(1000);
        Console.WriteLine("You have chosen: Sql Server localDb");
        break;
    default:
        Console.WriteLine("Choose between 1 and 3!!!");
        return;
}

userInput = "";
Thread.Sleep(1000);
Console.Clear();

Console.WriteLine("Choose Query type:");
Console.WriteLine("1. LINQ\n 2. SQL Raw");
userInput = Console.ReadLine();
switch (userInput)
{
    case "1":
        Console.WriteLine("You have chosen: LINQ");
        Thread.Sleep(1000);
        Console.Clear();
        break;
    case "2":
        Console.WriteLine("You have chosen: SQL Raw");
        Thread.Sleep(1000);
        Console.Clear();
        break;
    default:
        Console.WriteLine("Choose between 1 and 3!!!");
        return;
}
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
Thread.Sleep(1000);
Console.Clear();
