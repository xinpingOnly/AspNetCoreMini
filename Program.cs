using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace AspNetCoreMini
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            await new WebHostBuilder().UseMyServer().Configure(app =>
            {
                app.UseRoute();
                app.Use(next => context =>
                {
                    return Task.CompletedTask;
                });
            }).Build().StartAsync();

            Console.ReadLine();
        }

    }

}
