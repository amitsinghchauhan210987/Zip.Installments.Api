using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;
using Zip.Installments.Manager.CustomExceptionMiddleware;

namespace Zip.Installments.Manager.Dependency
{
    public static class ConfigureCustomExceptionMiddlewareDependency
    {
        public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
