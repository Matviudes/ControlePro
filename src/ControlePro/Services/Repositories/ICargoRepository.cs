using ControlePro.Models;

namespace ControlePro.Repositories;

public interface ICargoRepository
{
    Cargo Create(Cargo cargo);

    Cargo Get(int id);

    IReadOnlyCollection<Cargo> GetAll();

    Cargo Update(Cargo cargo);

    void Delete(Cargo cargo);
}