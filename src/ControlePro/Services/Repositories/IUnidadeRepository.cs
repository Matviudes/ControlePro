using ControlePro.Models;

namespace ControlePro.Repositories;

public interface IUnidadeRepository
{
    Unidade Create(Unidade unidade);

    Unidade Get(int id);

    IReadOnlyCollection<Unidade> GetAll();

    Unidade Update(Unidade unidade);

    void Delete(Unidade unidade);
}