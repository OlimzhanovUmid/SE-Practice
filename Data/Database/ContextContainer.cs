using Data.Model;

namespace Data.Database;

public static class ContextContainer
{
    private static AppContext? _context;

    public static AppContext? Init(ConnectionType connType, 
        string connString) => _context = new AppContext(connType, connString);

    public static AppContext? Init(
        ConnectionType connType) => _context = new AppContext(connType);
}