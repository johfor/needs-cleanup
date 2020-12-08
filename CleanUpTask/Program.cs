using Microsoft.Extensions.DependencyInjection;

namespace CleanUpTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            var services = ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetService<ConsoleApplication>().Run(args);
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<ILogger, Logger>();
            services.AddTransient<ConsoleApplication>();
            return services;
        }
    }
}
