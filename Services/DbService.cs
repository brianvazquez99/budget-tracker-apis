using System;
using System.Reflection.Metadata;
using Microsoft.Data.Sqlite;
using SQLitePCL;

namespace budget_tracker.Services;
public class DbService
{

    private readonly IConfiguration _config;

    public DbService(IConfiguration config)
    {
        _config = config;

    }

public SqliteConnection openConnection()
    {
        string conString = _config.GetConnectionString("DefaultConnection");
        return new SqliteConnection(conString);
    }

}
