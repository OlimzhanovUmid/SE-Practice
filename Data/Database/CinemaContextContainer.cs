using Data.Model;

namespace Data.Database;

public class CinemaContextContainer
{
    private static CinemaContext _context;

    public static CinemaContext? Init(ConnectionType connectionType, string connectionString)
    {
        var context = new CinemaContext(connectionType, connectionString);
        return _context = context;
    }
}