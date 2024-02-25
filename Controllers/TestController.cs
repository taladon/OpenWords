using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace server;
[ApiController]
[Route("api")]
public class TestController : ControllerBase
{
    [AllowAnonymous]
    [Route("test")]
    [HttpGet]
    public async Task<IActionResult> Test()
    {
        return Ok("hello world");
    }

}
