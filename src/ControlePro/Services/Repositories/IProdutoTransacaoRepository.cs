using ControlePro.Models;

namespace ControlePro.Repositories;

public interface IProdutoTransacaoRepository
{
    IReadOnlyCollection<ProdutoTransacao> CreateFor(Transacao transacao);

    IReadOnlyCollection<ProdutoTransacao> GetFor(Transacao transacao);

    IReadOnlyCollection<ProdutoTransacao> UpdateFor(Transacao transacao);

    void DeleteFor(Transacao transacao);
}