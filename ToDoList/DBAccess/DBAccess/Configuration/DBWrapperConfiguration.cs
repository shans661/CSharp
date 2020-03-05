using DBAccess.Features.ToDoLists;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBAccess.Configuration
{
    public static class DBWrapperConfiguration
    {
        public static void AddDBWrapperDependency(this IServiceCollection service)
        {
            service.AddScoped<IToDoListCommandRepository, ToDoListCommandRepository>();
        }
    }
}
