using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Shared.Abstractions
{
    public interface ICommand
    {
        bool IsValid();
    }
}
