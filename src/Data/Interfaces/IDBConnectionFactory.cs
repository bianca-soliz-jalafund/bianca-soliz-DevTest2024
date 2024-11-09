using System.Data;
namespace pollBack.src.Data.Interfaces;

public interface IDBConnectionFactory
{
    Task<IDbConnection> ConnectionAsync();
}
