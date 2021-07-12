using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmdbWebApi
{
    public class Program
    {
        //Create project-right template...asp.net core api
        //install the 2 packages with version (tool, sqlserver)
        //folder fr models
        //created model (actor with attributes like fn ln)
        //build no errors
        //app setting .json key name math dbcontext like (localhost in appsettings file)(make sure the name is prural)
        //geterate controller (math the appseting name)
        //added under the this method in
        //get connecting string match the key in app stting
        //generate migration
        //test postman

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
