using ControlePro.Models;

namespace ControlePro.Repositories;

public interface IPessoaFisicaRepository<TPessoa> where TPessoa : PessoaFisica, new()
{
    TPessoa Create(TPessoa pessoa);

    TPessoa Get(int id);

    IReadOnlyCollection<TPessoa> GetAll();

    TPessoa Update(TPessoa pessoa);

    void Delete(TPessoa pessoa);
}
