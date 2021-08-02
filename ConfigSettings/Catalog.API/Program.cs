using Catalog.API;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

// Using top-level programming
Console.WriteLine("Entering into Main method ... ");
var configuration = GetConfiguration();

IConfiguration GetConfiguration()
{
    var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddEnvironmentVariables();

    return builder.Build();
}

try
{
    Console.WriteLine("Configuring web host {0}...", Program.AppName);
    var host = CreateHostBuilder(configuration, args);
    host.Run();

    return 0;
}
catch (Exception exp)
{
    return 1;
}
finally
{
    //finally block
}

IWebHost CreateHostBuilder(IConfiguration configuration, string[] args) =>
  WebHost.CreateDefaultBuilder(args)
      .ConfigureAppConfiguration(x => x.AddConfiguration(configuration))
      .CaptureStartupErrors(false)
      .UseStartup<Startup>()
      .Build();

public static class Program
{
    public static string Namespace = typeof(Startup).Namespace;
    public static string AppName = Namespace.Substring(Namespace.LastIndexOf('.', Namespace.LastIndexOf('.') - 1) + 1);
}
