using System.Data.SqlClient;

namespace ControlePro.Commands;

public interface ISqlCommand : IDisposable
{
    void ExecuteNonQuery();

    SqlDataReader ExecuteReader();

    object? ExecuteScalar();

    T? ExecuteScalar<T>();

    void AddParameter(string parameterName, object? value);
}
