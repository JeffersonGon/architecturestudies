using Contoso.Store.Domain.Contexts.Entities;
using Contoso.Store.Domain.Contexts.Queries.CustomerQueries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Constoso.Store.Application.Repositories.Dapper.Repositories
{
    public interface ICustomerRepository
    {
        void Save(Customer model, int id);
        GetCustomerQueryResult GetByCpf(string cpf);
    }
}
