using Contoso.Store.Shared.Abstractions.HttpResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Shared.Implementations
{
    public class NotFoundResult : INotFoundResult
    {
        public NotFoundResult(string message, object data)
        {
            Message = message;
            Data = data;
        }

        public string Message { get; set; }
        public object Data { get; set; }
    }
}
