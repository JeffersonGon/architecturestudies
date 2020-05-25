using Contoso.Store.Shared.Abstractions.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Shared.Abstractions.Queries
{
    public interface IQueryHandler<T> where T : IQuery
    {
        IResult Handle(T query);
    }
}
