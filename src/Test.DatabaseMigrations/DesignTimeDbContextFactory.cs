using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace Test.DatabaseMigrations;

public class DesignTimeDbContextFactory<T> : IDesignTimeDbContextFactory<T> where T : DbContext
{
    public T CreateDbContext(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;

        var configuration = new ConfigurationBuilder()
            .SetBasePath(Environment.CurrentDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("MyDatabaseConnectionString");
        var options = new DbContextOptionsBuilder<T>().UseSqlServer(connectionString, SqlServerOptionsAction).Options;
        var dbContext = (T)Activator.CreateInstance(typeof(T), options)!;

        return dbContext;
    }

    private void SqlServerOptionsAction(SqlServerDbContextOptionsBuilder builder)
    {
        builder.MigrationsAssembly("PostAG.NotificationHub.DatabaseMigration");
    }
}
