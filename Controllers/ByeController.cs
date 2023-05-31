using Microsoft.AspNetCore.Mvc;

namespace HelloAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ByeController : ControllerBase
{
    private readonly ILogger<ByeController> _logger;

    public ByeController(ILogger<ByeController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetBye")]
    public IEnumerable<Bye> Get()
    {
        return Enumerable.Range(1, 1).Select(index => new Bye
        {
            Farewell = "Bye for now!"
        })
        .ToArray();
    }
}

