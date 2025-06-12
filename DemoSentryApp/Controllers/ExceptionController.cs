using Microsoft.AspNetCore.Mvc;

namespace DemoSentryApp.Controllers;

[ApiController]
public class ExceptionController : ControllerBase
{
    
    [HttpGet("my-exception")]
    public Task<IActionResult> Get()
    {
        throw new NotImplementedException("This is a test exception for Sentry.");
        // return NotFound();
    }

    [HttpGet("throw")]
    public IActionResult ThrowException()
    {
        string? test = null;
        int length = test.Length;
        
        return Ok("You won't reach this response.");
    }
}