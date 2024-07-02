using Npgsql;

namespace SharpTimer.Database
{
    public class PostgreSqlDatabase(string dbPath) : Database(dbPath, DatabaseType.PostgreSQL)
    {
    }
}