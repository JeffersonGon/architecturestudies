using Contoso.Store.Shared.Abstractions.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Shared.Implementations
{
    public class QueryResult : IQueryResult
    {
        public QueryResult(bool success, object data)
        {
            Success = success;
            Data = data;
        }

        public bool Success { get; set; }
        public object Data { get; set; }
    }
}
