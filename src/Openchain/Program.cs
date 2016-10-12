using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Openchain.Server;
using System;

namespace Openchain
{
    public class Program
    {
        public static void Main(string[] args) =>
            new WebHostBuilder()
            .UseKestrel()
            .UseContentRoot(Environment.GetEnvironmentVariable("HOME"))
            .UseIISIntegration()
            .UseStartup<Startup>()
            .Build()
            .Run();
    }
}
