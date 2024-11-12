using ControlePro.Models;

namespace ControlePro.Repositories;

public interface IPagamentoRepository
{
    Pagamento Create(Pagamento pagamento);

    Pagamento Get(int id);

    IReadOnlyCollection<Pagamento> GetAll();

    Pagamento Update(Pagamento pagamento);

    void Delete(Pagamento pagamento);
}
