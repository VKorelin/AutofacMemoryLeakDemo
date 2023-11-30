using Microsoft.AspNetCore.Mvc.Testing;
using AutofacStartup = AutofacAspNetCore.Startup;
using MicrosoftStartup = MicrosoftAspNetCore.Startup;

namespace CommonTests;

public class StatusTests
{
    [Test]
    [Repeat(1000000)]
    public async Task TestWithAutofac() => await RunTest<AutofacStartup>();

    [Test]
    [Repeat(1000000)]
    public async Task TestWithMicrosoft() => await RunTest<MicrosoftStartup>();

    private static async Task RunTest<T>() where T : class
    {
        await using var factory = new WebApplicationFactory<T>();
        var client = factory.CreateClient();
        var response = await client.GetAsync("status");
        response.EnsureSuccessStatusCode();
    }
}