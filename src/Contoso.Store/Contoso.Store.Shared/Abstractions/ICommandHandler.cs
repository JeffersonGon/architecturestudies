using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Shared.Abstractions
{
    public interface ICommandHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
