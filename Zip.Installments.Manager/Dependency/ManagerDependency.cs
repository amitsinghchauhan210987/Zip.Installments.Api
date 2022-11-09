using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using MediatR;
using Zip.Installments.Data.Interfaces;
using Zip.Installments.Data.Repositories;
using Microsoft.Extensions.Logging;
using Zip.Installments.Manager.CustomExceptionMiddleware;

namespace Zip.Installments.Manager.Dependency
{
    public static class ManagerDependency
    {
        public static void Register(IServiceCollection servicecollection)
        {
            RegisterRepos(servicecollection);
            servicecollection.AddMediatR(Assembly.GetExecutingAssembly());
            var serviceProvider = servicecollection.BuildServiceProvider();
            var logger = serviceProvider.GetService<ILogger<ExceptionMiddleware>>();
            servicecollection.AddSingleton(typeof(ILogger), logger);
        }
        public static void RegisterRepos(IServiceCollection services)
        {
            services.AddScoped<IInstallmentsRepository, InstallmentsRepository>();
        }
    }
}
