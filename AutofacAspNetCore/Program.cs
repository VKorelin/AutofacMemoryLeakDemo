using Autofac.Extensions.DependencyInjection;

namespace AutofacAspNetCore;

public class Program
{
    public static void Main(string[] args)
    {
        Host
            .CreateDefaultBuilder(args)
            .UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
            .Build()
            .Run();
    }
}