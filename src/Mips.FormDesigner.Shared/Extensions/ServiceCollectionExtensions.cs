using Microsoft.Extensions.DependencyInjection;
using Mips.FormDesigner.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mips.FormDesigner.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddFormBuilder(this IServiceCollection services)
        {
            services.AddSingleton<IContainerService, ContainerService>();
            services.AddSingleton<IFormsService, FormsService>();

            return services;
        }
    }
}
