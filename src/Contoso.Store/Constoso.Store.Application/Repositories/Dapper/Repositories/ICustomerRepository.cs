using Contoso.Store.Domain.Contexts.Entities;
using Contoso.Store.Domain.Contexts.Queries.CustomerQueries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Constoso.Store.Application.Repositories.Dapper.Repositories
{
    public interface ICustomerRepository : IRepository<Customer, GetCustomerQueryResult>
    {
        GetCustomerQueryResult GetByCpf(string cpf);
    }
}
