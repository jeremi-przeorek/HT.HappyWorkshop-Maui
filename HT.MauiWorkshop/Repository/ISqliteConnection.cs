using SQLite;

namespace HT.MauiWorkshop.Repository;

public interface ISqliteConnection
{
    SQLiteAsyncConnection GetAsyncConnection(string dbName);
}