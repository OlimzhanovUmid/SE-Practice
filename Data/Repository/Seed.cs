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
            CardCredentials = "1234 5678 9898 7654", 
            FullName = "Olimzhanov Umid", 
            Email = "uolimzhanov@gmail.com",
            PhoneNumber = "+998901234567"
        };

        var cinemaHall2 = new CinemaHall
        {
            NumberOfSeats = 2,
            Class = "Premium"
        };

        var session2 = new Session
        {
            CinemaHall = cinemaHall1,
            Date = "12.12.2012",
            Time = "21:12",
            MovieName = "A Knives Out Mystery: Glass Onion",
            SessionDuration = 132
        };

        var order2 = new Order
        {
            Price = 12000,
            Session = session1,
            User = user1,
            PaymentStatus = true
        };

        #endregion

        #region 3
        
        var user3 = new User
        {
            CardCredentials = "1234 5678 9898 7654", 
            FullName = "Olimzhanov Umid", 
            Email = "uolimzhanov@gmail.com",
            PhoneNumber = "+998901234567"
        };

        var cinemaHall3 = new CinemaHall
        {
            NumberOfSeats = 2,
            Class = "Premium"
        };

        var session3 = new Session
        {
            CinemaHall = cinemaHall1,
            Date = "12.12.2012",
            Time = "21:12",
            MovieName = "A Knives Out Mystery: Glass Onion",
            SessionDuration = 132
        };

        var order3 = new Order
        {
            Price = 12000,
            Session = session1,
            User = user1,
            PaymentStatus = true
        };

        #endregion

        #region 4
        
        var user4 = new User
        {
            CardCredentials = "1234 5678 9898 7654", 
            FullName = "Olimzhanov Umid", 
            Email = "uolimzhanov@gmail.com",
            PhoneNumber = "+998901234567"
        };

        var cinemaHall4 = new CinemaHall
        {
            NumberOfSeats = 2,
            Class = "Premium"
        };

        var session4 = new Session
        {
            CinemaHall = cinemaHall1,
            Date = "12.12.2012",
            Time = "21:12",
            MovieName = "A Knives Out Mystery: Glass Onion",
            SessionDuration = 132
        };

        var order4 = new Order
        {
            Price = 12000,
            Session = session1,
            User = user1,
            PaymentStatus = true
        };

        #endregion

        #region 5

        var user5 = new User
        {
            CardCredentials = "1234 5678 9898 7654", 
            FullName = "Olimzhanov Umid", 
            Email = "uolimzhanov@gmail.com",
            PhoneNumber = "+998901234567"
        };

        var cinemaHall5 = new CinemaHall
        {
            NumberOfSeats = 2,
            Class = "Premium"
        };

        var session5 = new Session
        {
            CinemaHall = cinemaHall1,
            Date = "12.12.2012",
            Time = "21:12",
            MovieName = "A Knives Out Mystery: Glass Onion",
            SessionDuration = 132
        };

        var order5 = new Order
        {
            Price = 12000,
            Session = session1,
            User = user1,
            PaymentStatus = true
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
            NumberOfSeats = 2,
            Class = "Premium"
        };

        var session6 = new Session
        {
            CinemaHall = cinemaHall1,
            Date = "12.12.2012",
            Time = "21:12",
            MovieName = "A Knives Out Mystery: Glass Onion",
            SessionDuration = 132
        };

        var order6 = new Order
        {
            Price = 12000,
            Session = session1,
            User = user1,
            PaymentStatus = true
        };

        #endregion
        
        #region 7
        
        var user7 = new User
        {
            CardCredentials = "1234 5678 9898 7654", 
            FullName = "Olimzhanov Umid", 
            Email = "uolimzhanov@gmail.com",
            PhoneNumber = "+998901234567"
        };

        var cinemaHall7 = new CinemaHall
        {
            NumberOfSeats = 2,
            Class = "Premium"
        };

        var session7 = new Session
        {
            CinemaHall = cinemaHall1,
            Date = "12.12.2012",
            Time = "21:12",
            MovieName = "A Knives Out Mystery: Glass Onion",
            SessionDuration = 132
        };

        var order7 = new Order
        {
            Price = 12000,
            Session = session1,
            User = user1,
            PaymentStatus = true
        };

        #endregion

        #region 8
        
        var user8 = new User
        {
            CardCredentials = "1234 5678 9898 7654", 
            FullName = "Olimzhanov Umid", 
            Email = "uolimzhanov@gmail.com",
            PhoneNumber = "+998901234567"
        };

        var cinemaHall8 = new CinemaHall
        {
            NumberOfSeats = 2,
            Class = "Premium"
        };

        var session8 = new Session
        {
            CinemaHall = cinemaHall1,
            Date = "12.12.2012",
            Time = "21:12",
            MovieName = "A Knives Out Mystery: Glass Onion",
            SessionDuration = 132
        };

        var order8 = new Order
        {
            Price = 12000,
            Session = session1,
            User = user1,
            PaymentStatus = true
        };

        #endregion

        #region 9

        var user9 = new User
        {
            CardCredentials = "1234 5678 9898 7654", 
            FullName = "Olimzhanov Umid", 
            Email = "uolimzhanov@gmail.com",
            PhoneNumber = "+998901234567"
        };

        var cinemaHall9 = new CinemaHall
        {
            NumberOfSeats = 2,
            Class = "Premium"
        };

        var session9 = new Session
        {
            CinemaHall = cinemaHall1,
            Date = "12.12.2012",
            Time = "21:12",
            MovieName = "A Knives Out Mystery: Glass Onion",
            SessionDuration = 132
        };

        var order9 = new Order
        {
            Price = 12000,
            Session = session1,
            User = user1,
            PaymentStatus = true
        };
        
        #endregion
        
        #region 10
        
        var user10 = new User
        {
            CardCredentials = "1234 5678 9898 7654", 
            FullName = "Olimzhanov Umid", 
            Email = "uolimzhanov@gmail.com",
            PhoneNumber = "+998901234567"
        };

        var cinemaHall10 = new CinemaHall
        {
            NumberOfSeats = 2,
            Class = "Premium"
        };

        var session10 = new Session
        {
            CinemaHall = cinemaHall1,
            Date = "12.12.2012",
            Time = "21:12",
            MovieName = "A Knives Out Mystery: Glass Onion",
            SessionDuration = 132
        };

        var order10 = new Order
        {
            Price = 12000,
            Session = session1,
            User = user1,
            PaymentStatus = true
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