using System.Data;
using Microsoft.Extensions.Options;
using Npgsql;
using pollBack.src.Data.Interfaces;

namespace pollBack.src.Data.Concretes;

public class DBConnection : IDBConnectionFactory
{
    private readonly DataOptions _option;
    public DBConnection(IOptions<DataOptions> options)
    {
        _option = options.Value;
    }

    public async Task<IDbConnection> ConnectionAsync()
    {
        var connection = new NpgsqlConnection(_option.DefaultConnection);
        await connection.OpenAsync();

        return connection;

    }
    
}
