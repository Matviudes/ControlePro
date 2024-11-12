﻿using ControlePro.Models;

namespace ControlePro.Repositories;

public interface ICompraRepository
{
    Compra Create(Compra compra);

    Compra Get(int id);

    IReadOnlyCollection<Compra> GetAll();

    Compra Update(Compra compra);

    void Delete(Compra compra);
}