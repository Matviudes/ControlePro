﻿using System.Data.SqlClient;
using ControlePro.Commands;
using ControlePro.Models;

namespace ControlePro.Repositories;

public class PessoaFisicaRepository<TPessoa> : IPessoaFisicaRepository<TPessoa> where TPessoa : PessoaFisica, new()
{
    private readonly ISqlCommandFactory commandFactory;
    private readonly IPessoaRepository<TPessoa> pessoaRepository;

    public PessoaFisicaRepository(ISqlCommandFactory commandFactory, IPessoaRepository<TPessoa> pessoaRepository)
    {
        this.commandFactory = commandFactory;
        this.pessoaRepository = pessoaRepository;
    }

    public TPessoa Create(TPessoa pessoa)
    {
        pessoa = pessoaRepository.Create(pessoa);
        using var command = commandFactory.Create("INSERT INTO Pessoas_Fisicas(Id, Cpf, Rg) VALUES(@Id, @Cpf, @Rg)");
        command.AddParameter("@Id", pessoa.Id);
        command.AddParameter("@Cpf", pessoa.Cpf);
        command.AddParameter("@Rg", pessoa.Rg);

        command.ExecuteNonQuery();

        return pessoa;
    }

    public TPessoa Get(int id)
    {
        using var command = commandFactory.Create("SELECT * FROM Pessoas_Fisicas WHERE Id = @Id");
        command.AddParameter("@Id", id);
        using var reader = command.ExecuteReader();
        if (reader.Read())
            return CreatePessoa(reader);
        return new();
    }

    public IReadOnlyCollection<TPessoa> GetAll()
    {
        using var command = commandFactory.Create("SELECT * FROM Pessoas_Fisicas");
        using var reader = command.ExecuteReader();

        var pessoas = new List<TPessoa>();
        while (reader.Read())
            pessoas.Add(CreatePessoa(reader));

        return pessoas;
    }

    public TPessoa Update(TPessoa pessoa)
    {
        pessoa = pessoaRepository.Update(pessoa);
        using var command = commandFactory.Create("UPDATE Pessoas_Fisicas SET Cpf = @Cpf, Rg = @Rg WHERE Id = @Id");
        command.AddParameter("@Id", pessoa.Id);
        command.AddParameter("@Cpf", pessoa.Cpf);
        command.AddParameter("@Rg", pessoa.Rg);

        command.ExecuteNonQuery();

        return pessoa;
    }

    public void Delete(TPessoa pessoa)
    {
        using var command = commandFactory.Create("DELETE FROM Pessoas_Fisicas WHERE Id = @Id");
        command.AddParameter("@Id", pessoa.Id);
        command.ExecuteNonQuery();

        pessoaRepository.Delete(pessoa);
    }

    private TPessoa CreatePessoa(SqlDataReader reader)
    {
        var id = (int)reader["Id"];
        var pessoa = pessoaRepository.Get(id);

        return pessoa with
        {
            Cpf = (string)reader["Cpf"],
            Rg = (string)reader["Rg"]
        };
    }
}
