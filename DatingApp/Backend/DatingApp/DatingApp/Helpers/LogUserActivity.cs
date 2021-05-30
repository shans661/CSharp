using DatingApp.Extensions;
using DatingApp.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace DatingApp.API.Helpers
{
    public class LogUserActivity : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var responseContext = await next();

            if(!responseContext.HttpContext.User.Identity.IsAuthenticated)
            {
                return;
            }

            var userId = responseContext.HttpContext.User.GetUserId();
            var userRepo = responseContext.HttpContext.RequestServices.GetService<IUserRepository>();
            var user = await userRepo.GetUserByIdAsync(userId);

            user.LastActive = DateTime.Now;
            await userRepo.SaveAllAsync();
        }
    }
}
