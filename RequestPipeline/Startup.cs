using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using RequestPipeline.Extensions;
using RequestPipeline.Middlewares;

namespace RequestPipeline
{
    public class Startup
    {
        string kt = "------";
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // cấu hình middleware
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.Use(async (context, next) => {
                await context.Response.WriteAsync($"<h1 style='color:red'>{kt}HelloWorld from middleware 1{kt}</h1>");
                await next.Invoke();
                await context.Response.WriteAsync($"<h1 style='color:red'>{kt}Returning from middleware 1{kt}</h1>");
            });
            app.Use(async (context, next) => {
                await context.Response.WriteAsync($"<h2 style='color:green'>{kt}HelloWorld from middleware 2{kt}</h1>");
                await next.Invoke();
                await context.Response.WriteAsync($"<h2 style='color:green'>{kt}Returning from middleware 2{kt}</h2>");
            });
            //app.UseMiddleware<SimpleMiddleware>();
            app.UseSimpleMiddleware();
            app.Run(async context =>
            {
                await context.Response.WriteAsync("<b style='color:blue'>HelloWorld from middleware 3</b>");
            });
        }
    }
}
