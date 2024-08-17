using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace NpgsqlMigrationSample;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);

        var dataSourceBuilder = new NpgsqlDataSourceBuilder("Host=localhost;Database=postgrestestdb;Username=postgres;Password=mypassword");
        var dataSource = dataSourceBuilder.Build();

        builder.Services.AddDbContext<MyDbContext>(options =>
            options.UseNpgsql(dataSource));


        builder.Services.AddHostedService<Worker>();

        var host = builder.Build();
        host.Run();
    }
}