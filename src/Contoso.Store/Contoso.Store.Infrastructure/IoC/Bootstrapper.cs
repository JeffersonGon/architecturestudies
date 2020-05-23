using Contoso.Store.Infrastructure.IoC.Application;
using Contoso.Store.Infrastructure.IoC.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Infrastructure.IoC
{
    public class Bootstrapper
    {
        public void BootstrapperRegisterServices(IServiceCollection services)
        {
            //Application
            new ApplicationBootstrapper().ChildServiceRegister(services);
            //Domain

            //Repository
            new RepositoryBootstrapper().ChildServiceRegister(services);
        }
    }
}
