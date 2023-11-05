using Microsoft.AspNetCore.Mvc;

namespace DistributedCalculatorWorker.Web;

public class CreateController : ControllerBase
{
    [HttpPost("/api/create")]
    public CreateResponse Create([FromBody] CreateRequest request)
    {
        Console.WriteLine(request);
        return new CreateResponse
        {
            JobId = Guid.NewGuid().ToString(),
            Result = "no result"
        };
    }
}

public record CreateRequest
{
    public string JobId { get; set; }
    public string Calculation { get; set; }
}

public record CreateResponse
{
    public string JobId { get; set; }
    public string Result { get; set; }
}