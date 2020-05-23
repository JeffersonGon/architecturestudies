﻿using Constoso.Store.Application.Repositories.Dapper.Repositories;
using Contoso.Store.Infrastructure.DataAccess.Dapper.Context;
using Contoso.Store.Infrastructure.DataAccess.Dapper.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Infrastructure.IoC.Repository
{
    internal class RepositoryBootstrapper
    {
        internal void ChildServiceRegister(IServiceCollection services)
        {
            services.AddScoped<DapperContext, DapperContext>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}
