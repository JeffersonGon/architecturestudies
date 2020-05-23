using Constoso.Store.Application.Handlers.CustomerHandler;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Infrastructure.IoC.Application
{
    internal class ApplicationBootstrapper
    {
        internal void ChildServiceRegister(IServiceCollection services)
        {
            services.AddTransient<CustomerHandler, CustomerHandler>();
        }
    }
}
