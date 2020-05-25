using Contoso.Store.Shared.Abstractions.HttpResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Shared.Implementations
{
    public class BadRequestResult : IBadRequestResult
    {
        public BadRequestResult(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
