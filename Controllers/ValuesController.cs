using Hangfire;
using Microsoft.AspNetCore.Mvc;

namespace HangFireApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        BackgroundJob.Enqueue(() => BackgroundTestServices.Test());
        return Ok("Hangfire çalıştı");
    }
}

public class BackgroundTestServices
{
    public static async Task Test()
    {
        Console.WriteLine("Hangfire çalışıyor: " + DateTime.Now);
    }
}
