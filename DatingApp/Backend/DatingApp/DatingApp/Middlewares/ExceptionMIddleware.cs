using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using DatingApp.Models;
using System.Text.Json;

namespace DatingApp.Middlewares
{
    public class ExceptionMIddleware
    {
        private readonly RequestDelegate m_Next;
        private readonly ILogger<ExceptionMIddleware> m_Logger;
        private readonly IWebHostEnvironment m_Env;

        public ExceptionMIddleware(RequestDelegate next, ILogger<ExceptionMIddleware> loggger,
        IWebHostEnvironment env)
        {
            m_Next = next;
            m_Logger = loggger;
            m_Env = env;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try{
                await m_Next(context);
            }
            catch(Exception ex)
            {
                m_Logger.LogError(ex, ex.Message);
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                var response= m_Env.IsDevelopment() ? new ApiException(context.Response.StatusCode, ex.Message,
                ex.StackTrace?.ToString()) : new ApiException(context.Response.StatusCode, "Internal error occurred");

                var options = new JsonSerializerOptions(){PropertyNamingPolicy = JsonNamingPolicy.CamelCase};

                var json = JsonSerializer.Serialize(response, options);

                await context.Response.WriteAsync(json);
            }
        }
    }
}