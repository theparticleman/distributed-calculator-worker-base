using Microsoft.AspNetCore.Mvc;

namespace DistributedCalculatorWorker.Web;

public class RegisterController: ControllerBase
{
    [HttpPost("api/register")]
    public async Task<IActionResult> RegisterAsync([FromBody] RegistrationRequest request)
    {
        Console.WriteLine(request == null ? "null" : request);
        return Ok();
    }
}

public record RegistrationRequest
{
    public string WorkerId { get; set; }
    public string TeamName { get; set; }
    public string CreateJobEndpoint { get; set; }
    public string ErrorCheckEndpoint { get; set; }
}