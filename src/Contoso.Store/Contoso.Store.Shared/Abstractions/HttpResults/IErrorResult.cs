using Contoso.Store.Shared.Abstractions.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Shared.Abstractions.HttpResults
{
    public interface IErrorResult : IResult
    {
        string Message { get; set; }
    }
}
