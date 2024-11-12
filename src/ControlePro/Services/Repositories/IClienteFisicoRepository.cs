﻿using ControlePro.Models;

namespace ControlePro.Repositories;

public interface IClienteRepository
{
    Cliente Create(Cliente cliente);

    Cliente Get(int id);

    IReadOnlyCollection<Cliente> GetAll();

    Cliente Update(Cliente cliente);

    void Delete(Cliente cliente);
}