using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplication1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMvc(options =>
            {
                options.OutputFormatters.Add(new XmlSerializerOutputFormatter());
            }).AddXmlDataContractSerializerFormatters();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //            app.UseEndpoints(endpoints =>
            //            {
            //                endpoints.MapGet("/get/", async context =>
            //{
            //    await context.Response.WriteAsync("Get Responce Statuc Code is 200 " + context.Request.QueryString);
            //    var fileName = @"C:\Users\Maksim\Documents\Visual Studio 2019\data.txt";
            //    using FileStream fs = File.OpenWrite(fileName);
            //    using var sr = new StreamWriter(fs);
            //    sr.WriteLine(context.Request.QueryString);







            //});

            //                endpoints.MapPost("/post/", async context =>
            //                            {

            //        await context.Response.WriteAsync("Post Responce Statuc Code is 200" + context.Request.QueryString);
            //        var fileName = @"C:\Users\Maksim\Documents\Visual Studio 2019\data.txt";
            //        using FileStream fs = File.OpenWrite(fileName);
            //        using var sr = new StreamWriter(fs);
            //        sr.WriteLine(context.Request.QueryString);


            //    });

            //            });






        }


    }

}




