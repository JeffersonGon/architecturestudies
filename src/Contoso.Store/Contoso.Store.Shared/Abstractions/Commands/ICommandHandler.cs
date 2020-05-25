using Contoso.Store.Shared.Abstractions.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Shared.Abstractions
{
    public interface ICommandHandler<T> where T : ICommand
    {
        IResult Handle(T command);
    }
}
