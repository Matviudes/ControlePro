using System.ComponentModel.DataAnnotations;

namespace ControlePro.Models;

public record Compra : Transacao
{
    public Compra()
    {
        Fornecedor = new();
    }

    public Fornecedor Fornecedor { get; init; }

    [DataType(DataType.Date)]
    [Display(Name = "Data da Compra")]
    public DateOnly DataCompra { get; init; }

    [DataType(DataType.Date)]
    [Display(Name = "Data da Entrega")]
    public DateOnly DataEntrega { get; init; }
}
