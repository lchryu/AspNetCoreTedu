using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuyenTapAspNetCore.Middlewares
{
    public class SimpleMiddleware
    {
        private readonly RequestDelegate _next;
        public SimpleMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("<div> Hello World from the simple extension</div>");
            await _next(context);
            await context.Response.WriteAsync("<div> Returning from the simple extension</div>");
        }
    }
}
