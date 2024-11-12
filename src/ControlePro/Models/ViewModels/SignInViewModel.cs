﻿using System.ComponentModel.DataAnnotations;

namespace ControlePro.ViewModels;

public class SignInViewModel : ViewModelBase
{
    [StringLength(50, MinimumLength = 3, ErrorMessage = "O usuário deve ter entre 3 e 50 caracteres")]
    [Display(Name = "Usuário")]
    public string? User { get; set; }

    [DataType(DataType.Password)]
    [StringLength(32, MinimumLength = 3, ErrorMessage = "A senha deve ter entre 3 e 32 caracteres")]
    [Display(Name = "Senha")]
    public string? Password { get; set; }
}
