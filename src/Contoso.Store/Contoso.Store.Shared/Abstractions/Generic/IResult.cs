using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Shared.Abstractions.Generic
{
    public interface IResult
    {
        object Data { get; set; }
    }
}
