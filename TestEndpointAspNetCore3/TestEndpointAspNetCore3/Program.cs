using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TestEndpointAspNetCore3
{
    public class Program
    {
        public static void Main ( string[] args )
        {
            CreateHostBuilder ( args ).Build ().Run ();
        }

        public static IHostBuilder CreateHostBuilder ( string[] args ) =>
            Host.CreateDefaultBuilder ( args )
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders ();
                    logging.AddConsole ();
                } )
                .ConfigureWebHostDefaults ( webBuilder =>
                  {
                      webBuilder.UseStartup<Startup> ();
                      webBuilder.UseUrls ( "http://*:7050" );
                      webBuilder.ConfigureKestrel ( serverOptions =>
                        {
                            serverOptions.Listen ( IPAddress.Any , 7050 , listenOptions =>
                            {
                                //listenOptions.UseConnectionLogging ();
                            } );
                        } );
                      webBuilder.UseKestrel ();
                  } );
    }
}
