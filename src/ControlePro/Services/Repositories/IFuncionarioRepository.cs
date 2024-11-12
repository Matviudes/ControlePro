using ControlePro.Models;

namespace ControlePro.Repositories;

public interface IFuncionarioRepository
{
    Funcionario Create(Funcionario funcionario);

    Funcionario Get(int id);

    IReadOnlyCollection<Funcionario> GetAll();

    Funcionario Update(Funcionario funcionario);

    void Delete(Funcionario funcionario);
}
