using Data.Model;

namespace Data.Database;

public class CinemaContextContainer
{
    private static AppContext _context;

    public static AppContext? Init(ConnectionType connectionType, string connectionString)
    {
        var context = new AppContext(connectionType, connectionString);
        return _context = context;
    }
    public static AppContext? Init(ConnectionType connectionType)
    {
        var context = new AppContext(connectionType);
        return _context = context;
    }
}