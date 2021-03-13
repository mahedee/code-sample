using HRM.Db;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HRM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();

            // 1. Get the IHost which will host this application
            var host = CreateHostBuilder(args).Build();

            // 2. Find the service within the scope to use
            using (var scope = host.Services.CreateScope())
            {
                // 3. Get the instance of HRMContext in our service layer
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<HRMContext>();

                // 4. Call the SeedDataGenerator to generate seed data
                SeedDataGenerator.Initialize(services);  
            }

            // Run the application 
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
