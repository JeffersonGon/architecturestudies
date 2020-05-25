using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Shared.Abstractions.Queries
{
    public interface IQuery
    {
        bool IsValidResult();
    }
}
