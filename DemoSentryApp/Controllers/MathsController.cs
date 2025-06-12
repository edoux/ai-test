using DemoSentryApp.Request;
using Microsoft.AspNetCore.Mvc;

namespace DemoSentryApp.Controllers;

[ApiController]
public class MathsController: ControllerBase
{
    [HttpPost("maths/sqrt")]
    public Task<IActionResult> Sqrt([FromBody] Equation equation)
    {
        var result = Math.Sqrt(equation.Value);
        return Task.FromResult<IActionResult>(Ok(Math.Round(result, 3)));
    }
}