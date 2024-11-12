using System.ComponentModel.DataAnnotations;

namespace ControlePro.Models;

public abstract record Entidade
{
    [Display(Name = "Código")]
    public int Id { get; init; }
}
