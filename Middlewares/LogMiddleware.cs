using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap01.Middlewares
{
    public class LogMiddleware
    {
        private RequestDelegate _next;
        public LogMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
           
            await _next(context);

            stopwatch.Stop();

            Console.WriteLine($"demorou {stopwatch.ElapsedMilliseconds.ToString()}");
        }

      
    }

    public static class MiddewareExtension
    {
        public static IApplicationBuilder UseMeuLogPreza(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogMiddleware>();
        }
    }
}
