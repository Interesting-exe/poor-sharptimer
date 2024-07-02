using MySqlConnector;

namespace SharpTimer.Database
{
    public class MySqlDatabase(string dbPath) : Database(dbPath, DatabaseType.MySQL)
    {
    }
}