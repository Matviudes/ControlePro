namespace ControlePro.Commands;

public interface ISqlCommandFactory
{
    ISqlCommand Create(string query);
}
