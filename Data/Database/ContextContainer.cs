using Data.Model;

namespace Data.Database;

public static class ContextContainer
{
    private static AppContext? _context;

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