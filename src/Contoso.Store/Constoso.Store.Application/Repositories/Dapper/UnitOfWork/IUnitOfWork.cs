using Constoso.Store.Application.Repositories.Dapper.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Constoso.Store.Application.Repositories.Dapper.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customers { get; }
        void Commit();
        void Rollback();
    }
}
