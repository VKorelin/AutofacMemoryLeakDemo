using Common;

namespace MicrosoftAspNetCore;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddSingleton<IStatusProvider, StatusProvider>();
    }

    public void Configure(IApplicationBuilder app)
        => app
            .UseRouting()
            .UseEndpoints(endpoints => endpoints.MapControllers());
}