using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zip.Installments.Manager.Dependency
{
    public static class ManagerServiceCollectionExtension
    {
        public static void AddManagerDependency(this IServiceCollection services)
        {
            ManagerDependency.Register(services);
        }
    }
}
