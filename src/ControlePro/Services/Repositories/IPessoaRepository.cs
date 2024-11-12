﻿using ControlePro.Models;

namespace ControlePro.Repositories;

public interface IPessoaRepository<TPessoa> where TPessoa : Pessoa, new()
{
    TPessoa Create(TPessoa pessoa);

    TPessoa Get(int id);

    IReadOnlyCollection<TPessoa> GetAll();

    TPessoa Update(TPessoa pessoa);

    void Delete(TPessoa pessoa);
}
