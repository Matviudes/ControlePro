using System.ComponentModel.DataAnnotations;

namespace ControlePro.ViewModels;

public abstract class ViewModelBase
{
    [Display(Name = "Erro")]
    public string? Error { get; init; }
}
