using SQLite;

namespace HT.MauiWorkshop.Repository;

public class SqliteConnection : ISqliteConnection
{
    private const SQLite.SQLiteOpenFlags Flags =
        // open the database in read/write mode
        SQLite.SQLiteOpenFlags.ReadWrite |
        // create the database if it doesn't exist
        SQLite.SQLiteOpenFlags.Create |
        // enable multi-threaded database access
        SQLite.SQLiteOpenFlags.SharedCache;

    private SQLiteAsyncConnection _asyncDbConnection;

    public SQLiteAsyncConnection GetAsyncConnection(string dbName)
    {
        if (_asyncDbConnection == null)
        {
            var dbPath = GetDbFilePath(dbName);
            _asyncDbConnection = new SQLiteAsyncConnection(dbPath, Flags);
            _asyncDbConnection.CreateTableAsync<CarEntity>();
        }

        return _asyncDbConnection;
    }

    private static string GetDbFilePath(string dbName)
    {
        return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), $"{dbName}");
    }
}