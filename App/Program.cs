using Data.Model;
using Data.Repository;

Console.WriteLine("Choose connection type:");
Console.WriteLine("1. Sqlite\n2. Sql Server\n3. Sql Server LocalDb");
Console.Write("Enter connection type: ");
var userInput = Console.ReadLine();
switch (userInput)
{
    case "1":
        Repository.Init(ConnectionType.Sqlite, "Data Source = cinema.db");
        Console.WriteLine("You have chosen: Sqlite");
        Thread.Sleep(1000);
        break;
    case "2":
        Repository.Init(ConnectionType.Sqlserver,
            @"Server=(localdb)\msSqlLocalDb; Database=cinema; Trusted_Connection = true");
        Console.WriteLine("You have chosen: Sql Server");
        Thread.Sleep(1000);
        break;
    case "3":
        Repository.Init(ConnectionType.SqlserverLocaldb);
        Console.WriteLine("You have chosen: Sql Server localDb");
        Thread.Sleep(1000);
        break;
    default:
        Console.WriteLine("Choose between 1 and 3!!!");
        return;
}

Thread.Sleep(1000);
Console.Clear();

Repository.EnsureDeleted();
Repository.EnsureCreated();
Seed.Init();


Console.WriteLine("Choose Query type:");
Console.WriteLine("1. LINQ\n2. SQL Raw");
Console.Write("Enter number: ");
userInput = Console.ReadLine();
switch (userInput)
{
    case "1":
        Console.WriteLine("You have chosen: LINQ");
        Thread.Sleep(1000);
        Console.Clear();
        
        Console.WriteLine("Choose query:");
        Console.WriteLine("1. Get users who didn't pay\n" +
                          "2. Get orders cheaper than\n" +
                          "3. Get cinema halls with X seats\n" +
                          "4. Get movies with duration more than\n" +
                          "5. Get movies with duration less than");
        Console.Write("Enter number: ");
        userInput = Console.ReadLine();
        Console.WriteLine($"You have chosen: {userInput}");
        Thread.Sleep(1000);
        Console.Clear();
        switch (userInput)
        {
            case "1":
                Console.WriteLine(Repository.PrintUsers(Repository.Linq.GetUsersWhoDidNotPay()));
                break;
            case "2":
                Console.Write("Enter price: ");
                var price = int.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine(Repository.PrintOrders(Repository.Linq.GetOrdersCheaperThan(price)));
                break;
            case "3":
                Console.Write("Enter number of seats: ");
                var seats = int.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine(Repository.PrintCinemaHalls(Repository.Linq.GetHallsWithXSeats(seats)));
                break;
            case "4":
                Console.Write("Enter duration: ");
                var durationM = int.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine(Repository.PrintSessions(Repository.Linq.GetMovieWithDurationMoreThan(durationM)));
                break;
            case "5":
                Console.Write("Enter duration: ");
                var durationL = int.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine(Repository.PrintSessions(Repository.Linq.GetMovieWithDurationLessThan(durationL)));
                break;
            default:
                Console.WriteLine("Choose between 1 and 5!!!");
                return;
        }
        break;
    case "2":
        Console.WriteLine("You have chosen: SQL Raw");
        Thread.Sleep(1000);
        Console.Clear();
        
        Console.WriteLine("Choose query:");
        Console.WriteLine("1. Get users with name like\n" +
                          "2. Get orders cheaper than\n" +
                          "3. Get cinema halls with X seats\n" +
                          "4. Get movies with duration more than\n" +
                          "5. Get movies with duration less than");
        Console.Write("Enter number: ");
        userInput = Console.ReadLine();
        switch (userInput)
        {
            case "1":
                Console.Write("Enter name: ");
                var name = Console.ReadLine() ?? "";
                Console.WriteLine(Repository.PrintUsers(Repository.SqlRaw.GetUsersWithNameLike(name)));
                break;
            case "2":
                Console.Write("Enter price: ");
                var price = int.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine(Repository.PrintOrders(Repository.SqlRaw.GetOrdersCheaperThan(price)));
                break;
            case "3":
                Console.Write("Enter number of seats: ");
                var seats = int.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine(Repository.PrintCinemaHalls(Repository.SqlRaw.GetHallsWithXSeats(seats)));
                break;
            case "4":
                Console.Write("Enter duration: ");
                var durationM = int.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine(Repository.PrintSessions(Repository.SqlRaw.GetMovieWithDurationMoreThan(durationM)));
                break;
            case "5":
                Console.Write("Enter duration: ");
                var durationL = int.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine(Repository.PrintSessions(Repository.SqlRaw.GetMovieWithDurationLessThan(durationL)));
                break;
            default:
                Console.WriteLine("Choose between 1 and 5!!!");
                return;
        }
        break;
    default:
        Console.WriteLine("Choose between 1 and 2!!!");
        return;
}
/*
Repository.EnsureDeleted();
Repository.EnsureCreated();

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
*/
