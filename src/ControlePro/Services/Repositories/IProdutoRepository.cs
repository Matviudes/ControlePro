using ControlePro.Models;

namespace ControlePro.Repositories;

public interface IProdutoRepository
{
    Produto Create(Produto produto);

    Produto Get(int id);

    IReadOnlyCollection<Produto> GetAll();

    Produto Update(Produto produto);

    void Delete(Produto produto);
}
