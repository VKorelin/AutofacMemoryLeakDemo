using Autofac;
using Common;

namespace AutofacAspNetCore;

public class Startup
{
    public void ConfigureServices(IServiceCollection services) 
        => services.AddControllers();

    public void ConfigureContainer(ContainerBuilder builder) 
        => builder.RegisterType<StatusProvider>().AsImplementedInterfaces().SingleInstance();

    public void Configure(IApplicationBuilder app)
        => app
            .UseRouting()
            .UseEndpoints(endpoints => endpoints.MapControllers());
}