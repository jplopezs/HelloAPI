using Microsoft.AspNetCore.Mvc;

namespace HelloAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    private readonly ILogger<HelloController> _logger;

    public HelloController(ILogger<HelloController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetHello")]
    public IEnumerable<Hello> Get()
    {
        return Enumerable.Range(1, 1).Select(index => new Hello
        {
            Greeting = "Hello brand new world!"
        })
        .ToArray();
    }
}

