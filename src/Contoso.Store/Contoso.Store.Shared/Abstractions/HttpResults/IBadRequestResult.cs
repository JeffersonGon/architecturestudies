using Contoso.Store.Shared.Abstractions.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Shared.Abstractions.HttpResults
{
    public interface IBadRequestResult : IResult
    {
        bool Success { get; set; }
        string Message { get; set; }
    }
}
