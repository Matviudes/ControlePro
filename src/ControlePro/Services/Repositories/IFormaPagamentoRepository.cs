﻿using ControlePro.Models;

namespace ControlePro.Repositories;

public interface IFormaPagamentoRepository
{
    FormaPagamento Create(FormaPagamento formaPagamento);

    FormaPagamento Get(int id);

    IReadOnlyCollection<FormaPagamento> GetAll();

    FormaPagamento Update(FormaPagamento formaPagamento);

    void Delete(FormaPagamento formaPagamento);
}