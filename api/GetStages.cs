using FunctionApp1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace api
{
    public class GetStages
    {
        private readonly ILogger<GetStages> _logger;

        public GetStages(ILogger<GetStages> logger)
        {
            _logger = logger;
        }

        [Function("GetStages")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("Get stages");

            var stages = new List<Stage>()
            {
                new Stage()
                {
                    Id = 786,
                    Name = "Mainstage"
                }
            };

            return new OkObjectResult(stages);
        }
    }
}
