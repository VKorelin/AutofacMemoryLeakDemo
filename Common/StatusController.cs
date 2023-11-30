using Microsoft.AspNetCore.Mvc;

namespace Common;

[Route("[controller]")]
public class StatusController : ControllerBase
{
    private readonly IStatusProvider _statusProvider;

    public StatusController(IStatusProvider statusProvider) => _statusProvider = statusProvider;

    [HttpGet]
    public string Get() => _statusProvider.GetStatus();
}