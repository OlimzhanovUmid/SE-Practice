using Data.Model;

namespace Data.Repository;

public static class Seed
{
    public static void Init()
    {
        #region 1
        
        var user1 = new User
        {
            CardCredentials = "1234 5678 9898 7654", 
            FullName = "Olimzhanov Umid", 
            Email = "uolimzhanov@gmail.com",
            PhoneNumber = "+998901234567"
        };

        var cinemaHall1 = new CinemaHall
        {
            NumberOfSeats = 2,
            Class = "Premium"
        };

        var session1 = new Session
        {
            CinemaHall = cinemaHall1,
            Date = "12.12.2012",
            Time = "21:12",
            MovieName = "A Knives Out Mystery: Glass Onion",
            SessionDuration = 132
        };

        var order1 = new Order
        {
            Price = 12000,
            Session = session1,
            User = user1,
            PaymentStatus = true
        };

        #endregion

        #region 2
        
        var user2 = new User
        {
            CardCredentials = "3421 5678 9898 7654", 
            FullName = "Mirgulom Mirsolikhov", 
            Email = "mirsolikhov@gmail.com",
            PhoneNumber = "+998901234567"
        };

        var cinemaHall2 = new CinemaHall
        {
            NumberOfSeats = 5,
            Class = "Ultra"
        };

        var session2 = new Session
        {
            CinemaHall = cinemaHall2,
            Date = "11.11.2013",
            Time = "11:11",
            MovieName = "Astral",
            SessionDuration = 112
        };

        var order2 = new Order
        {
            Price = 14000,
            Session = session2,
            User = user2,
            PaymentStatus = true
        };

        #endregion

        #region 3
        
        var user3 = new User
        {
            CardCredentials = "1234 8765 9898 7654", 
            FullName = "Nuraliev Umid", 
            Email = "nuraliev@gmail.com",
            PhoneNumber = "+998901234567"
        };

        var cinemaHall3 = new CinemaHall
        {
            NumberOfSeats = 2,
            Class = "S"
        };

        var session3 = new Session
        {
            CinemaHall = cinemaHall3,
            Date = "12.12.2012",
            Time = "21:12",
            MovieName = "The boys: The movie",
            SessionDuration = 132
        };

        var order3 = new Order
        {
            Price = 22000,
            Session = session3,
            User = user3,
            PaymentStatus = true
        };

        #endregion

        #region 4
        
        var user4 = new User
        {
            CardCredentials = "1234 5678 9898 7654", 
            FullName = "Pulatxojaev Akbarxoja", 
            Email = "pulatxojaev@gmail.com",
            PhoneNumber = "+998901234567"
        };

        var cinemaHall4 = new CinemaHall
        {
            NumberOfSeats = 2,
            Class = "BussinesMas"
        };

        var session4 = new Session
        {
            CinemaHall = cinemaHall4,
            Date = "12.12.2014",
            Time = "21:12",
            MovieName = "Free Guy",
            SessionDuration = 142
        };

        var order4 = new Order
        {
            Price = 300,
            Session = session4,
            User = user4,
            PaymentStatus = false
        };

        #endregion

        #region 5

        var user5 = new User
        {
            CardCredentials = "1234 5678 8989 7654", 
            FullName = "Alimov Shukrullo", 
            Email = "alimov@gmail.com",
            PhoneNumber = "+998901234567"
        };

        var cinemaHall5 = new CinemaHall
        {
            NumberOfSeats = 2,
            Class = "Est deshevle"
        };

        var session5 = new Session
        {
            CinemaHall = cinemaHall5,
            Date = "12.12.2012",
            Time = "21:12",
            MovieName = "Fast & Furious",
            SessionDuration = 132
        };

        var order5 = new Order
        {
            Price = 100,
            Session = session5,
            User = user5,
            PaymentStatus = false
        };
        
        #endregion

        #region 6
        
        var user6 = new User
        {
            CardCredentials = "1234 5678 9898 7654", 
            FullName = "Olimzhanov Umid", 
            Email = "uolimzhanov@gmail.com",
            PhoneNumber = "+998901234567"
        };

        var cinemaHall6 = new CinemaHall
        {
            NumberOfSeats = 3,
            Class = "Premium"
        };

        var session6 = new Session
        {
            CinemaHall = cinemaHall6,
            Date = "12.12.2012",
            Time = "21:12",
            MovieName = "A Knives Out Mystery: Glass Onion",
            SessionDuration = 132
        };

        var order6 = new Order
        {
            Price = 12000,
            Session = session6,
            User = user6,
            PaymentStatus = true
        };

        #endregion

        #region 7
        
        var user7 = new User
        {
            CardCredentials = "3421 5678 9898 7654", 
            FullName = "Mirgulom Mirsolikhov", 
            Email = "mirsolikhov@gmail.com",
            PhoneNumber = "+998901234567"
        };

        var cinemaHall7 = new CinemaHall
        {
            NumberOfSeats = 5,
            Class = "Ultra"
        };

        var session7 = new Session
        {
            CinemaHall = cinemaHall7,
            Date = "11.11.2013",
            Time = "11:11",
            MovieName = "Astral",
            SessionDuration = 112
        };

        var order7 = new Order
        {
            Price = 14000,
            Session = session7,
            User = user7,
            PaymentStatus = true
        };

        #endregion

        #region 8
        
        var user8 = new User
        {
            CardCredentials = "1234 8765 9898 7654", 
            FullName = "Nuraliev Umid", 
            Email = "nuraliev@gmail.com",
            PhoneNumber = "+998901234567"
        };

        var cinemaHall8 = new CinemaHall
        {
            NumberOfSeats = 4,
            Class = "S"
        };

        var session8 = new Session
        {
            CinemaHall = cinemaHall8,
            Date = "12.12.2012",
            Time = "21:12",
            MovieName = "The boys: The movie",
            SessionDuration = 132
        };

        var order8 = new Order
        {
            Price = 22000,
            Session = session8,
            User = user8,
            PaymentStatus = true
        };

        #endregion

        #region 9
        
        var user9 = new User
        {
            CardCredentials = "1234 5678 9898 7654", 
            FullName = "Pulatxojaev Akbarxoja", 
            Email = "pulatxojaev@gmail.com",
            PhoneNumber = "+998901234567"
        };

        var cinemaHall9 = new CinemaHall
        {
            NumberOfSeats = 6,
            Class = "BussinesMas"
        };

        var session9 = new Session
        {
            CinemaHall = cinemaHall9,
            Date = "12.12.2014",
            Time = "21:12",
            MovieName = "Free Guy",
            SessionDuration = 142
        };

        var order9 = new Order
        {
            Price = 300,
            Session = session9,
            User = user9,
            PaymentStatus = false
        };

        #endregion

        #region 10

        var user10 = new User
        {
            CardCredentials = "1234 5678 8989 7654", 
            FullName = "Alimov Shukrullo", 
            Email = "alimov@gmail.com",
            PhoneNumber = "+998901234567"
        };

        var cinemaHall10 = new CinemaHall
        {
            NumberOfSeats = 7,
            Class = "Est deshevle"
        };

        var session10 = new Session
        {
            CinemaHall = cinemaHall10,
            Date = "12.12.2012",
            Time = "21:12",
            MovieName = "Fast & Furious",
            SessionDuration = 132
        };

        var order10 = new Order
        {
            Price = 100,
            Session = session10,
            User = user10,
            PaymentStatus = false
        };
        
        #endregion


        #region add and save

        Repository.AddUsersRange(new List<User> {user1, user2, user3, user4, user5, user6, user7, user8, user9, user10});
        Repository.AddCinemaHallsRange(new List<CinemaHall> {cinemaHall1, cinemaHall2, cinemaHall3, cinemaHall4, cinemaHall5, cinemaHall6, cinemaHall7, cinemaHall8, cinemaHall9, cinemaHall10});
        Repository.AddSessionsRange(new List<Session> {session1, session2, session3, session4, session5, session6, session7, session8, session9, session10});
        Repository.AddOrdersRange(new List<Order> {order1, order2, order3, order4, order5, order6, order7, order8, order9, order10});
        Repository.SaveChanges();

        #endregion
    }
}