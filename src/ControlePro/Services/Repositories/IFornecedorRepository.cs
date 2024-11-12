using ControlePro.Models;

namespace ControlePro.Repositories;

public interface IFornecedorRepository
{
    Fornecedor Create(Fornecedor fornecedor);

    Fornecedor Get(int id);

    IReadOnlyCollection<Fornecedor> GetAll();

    Fornecedor Update(Fornecedor fornecedor);

    void Delete(Fornecedor fornecedor);
}
