using Contoso.Store.Shared.Abstractions.Queries;
using FluentValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Domain.Contexts.Queries.CustomerQueries
{
    public class GetAllCustomersQueryResult : GetCustomerQueryResult
    {
        public List<GetCustomerQueryResult> Clientes { get; set; }
    }
}
