using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Shared.Abstractions
{
    public interface ICommandResult
    {
        bool Success { get; set; }
        string Message { get; set; }
        object Data { get; set; }
    }
}
