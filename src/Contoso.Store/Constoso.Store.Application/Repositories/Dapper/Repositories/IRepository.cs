using System;
using System.Collections.Generic;
using System.Text;

namespace Constoso.Store.Application.Repositories.Dapper.Repositories
{
    public interface IRepository<TCommand, TQuery> where TCommand : class where TQuery : class
    {
        void Save(TCommand model);
        IList<TQuery> GetAll();
        void Update(TCommand model);
    }
}
