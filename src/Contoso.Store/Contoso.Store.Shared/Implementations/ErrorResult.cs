using Contoso.Store.Shared.Abstractions.HttpResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Shared.Implementations
{
    public class ErrorResult : IErrorResult
    {
        public ErrorResult(string message, object data)
        {
            Message = message;
            Data = data;
        }

        public string Message { get; set; }
        public object Data { get; set; }
    }
}
