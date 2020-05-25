using Contoso.Store.Shared.Abstractions.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Shared.Abstractions.Queries
{
    public interface IQueryResult : IResult
    {
        bool Success { get; set; }
    }
}
