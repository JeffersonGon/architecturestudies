using Contoso.Store.Shared.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Shared.Implementations
{
    public class CommandResult : ICommandResult
    {
        public CommandResult(bool success, string message, object data)
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
