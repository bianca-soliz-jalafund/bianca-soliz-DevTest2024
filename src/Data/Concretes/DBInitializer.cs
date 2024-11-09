using System.Reflection;
using DbUp;
using Microsoft.Extensions.Options;
using pollBack.src.Data.Interfaces;

namespace pollBack.src.Data.Concretes;

public class DBInitializer : IDBInitializer
{
    private readonly DataOptions _option;

    public DBInitializer(IOptions<DataOptions> options)
    {
        _option = options.Value;
    }
    
    public void InitializerDB()
    {
        EnsureDatabase.For.PostgresqlDatabase(_option.DefaultConnection);

        var dbUp  = DeployChanges.To
        .PostgresqlDatabase(_option.DefaultConnection)
        .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
        .WithTransaction()
        .LogToConsole()
        .Build();

        var response = dbUp.PerformUpgrade();

        if (!response.Successful)
        {
            Console.WriteLine("Migration invalid");
        }
        
    }
}
