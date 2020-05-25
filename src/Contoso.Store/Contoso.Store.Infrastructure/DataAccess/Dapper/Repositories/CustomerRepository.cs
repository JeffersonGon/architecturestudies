using Constoso.Store.Application.Repositories.Dapper.Repositories;
using Contoso.Store.Domain.Contexts.Entities;
using Contoso.Store.Domain.Contexts.Queries.CustomerQueries;
using Contoso.Store.Infrastructure.DataAccess.Dapper.Context;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contoso.Store.Infrastructure.DataAccess.Dapper.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DapperContext _context;
        public CustomerRepository(DapperContext context)
        {
            _context = context;
        }

        IList<GetCustomerQueryResult> IRepository<Customer, GetCustomerQueryResult>.GetAll() => _context
            .Connection
            .Query<GetCustomerQueryResult>(
            "SELECT Nome, Documento, Telefone, Email FROM [dbo].[Cliente]")
            .ToList();

        public GetCustomerQueryResult GetByCpf(string cpf) => _context
            .Connection
            .Query<GetCustomerQueryResult>(
                @"SELECT Nome, Documento, Telefone, Email FROM [dbo].[Cliente] Where Documento = @Cpf",
                param: new { Cpf = cpf })
            .FirstOrDefault();

        public void Save(Customer model)
        {
            _context.Connection.ExecuteScalar(
                "INSERT INTO Cliente (Id, Nome, Documento, Email, Telefone) VALUES (@Id, @Nome, @Documento, @Email, @Telefone);",
                param: new { Id = model.Id, Nome = model.Name.ToString(), Documento = model.CPF.Number, Email = model.Email.Address, Telefone = model.Telefone }
            );
        }

        public void Update(Customer model)
        {
            _context.Connection.ExecuteScalar(
                "UPDATE Cliente SET Nome = @Nome, Documento = @Documento, Email = @Email, Telefone = @Telefone Where Id = @Documento",
                param: new { Id = model.Id, Nome = model.Name, Documento = model.CPF.Number, Email = model.Email.Address, Telefone = model.Telefone }
            );
        }
    }
}
