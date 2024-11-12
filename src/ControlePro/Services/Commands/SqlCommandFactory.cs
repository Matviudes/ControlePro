using System.Data.SqlClient;

namespace ControlePro.Commands;

public class SqlCommandFactory : ISqlCommandFactory
{
    private readonly SqlConnection connection;

    public SqlCommandFactory(SqlConnection connection)
    {
        this.connection = connection;
    }

    public ISqlCommand Create(string query)
    {
        return new SqlCommandWrapper(query, connection);
    }
}
