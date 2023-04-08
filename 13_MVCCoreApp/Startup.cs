﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;

namespace _13_MVCCoreApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseMvcWithDefaultRoute();

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute("secure", "secure", new
            //    {
            //        Controllers="Admin",Action="Index"
            //    });
            //    routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            //});
            // app.UseMvc();
            app.UseMvc(routes =>
            {
                //    routes.MapRoute(
                //        name: "secure",
                //        template: "secure",
                //        defaults: new { controller = "Admin", action = "Index" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id:alpha:minlength(6)?}");
                //routes.MapRoute("default", "{controller=Home}/{action=Index}/{id}",
                //    new { Controllers = "Home", action = "Index" },
                //    new
                //    {
                //        id = new CompositeRouteConstraint(
                //            new IRouteConstraint[]
                //            {
                //                new AlphaRouteConstraint(),
                //                new MinLengthRouteConstraint(6)
                //            })
                //    });
                //routes.MapRoute("default",
                //    "post/{id:int}",
                //    new { controller = "Post", action="PostsByID"});

                //routes.MapRoute("anotherRoute",
                //    "post/{id:alpha}",
                //    new { controller="Post",action="PostByPostName"});
                //routes.MapRoute("default",
                //    "{controller}/{action}/{year:regex(^\\d{{4}}$)}",
                //    new { controller = "Home", action = "Index"});
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Failed to find route");
            });
        }
    }
}
