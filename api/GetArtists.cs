using FunctionApp1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public class GetArtists
    {
        private readonly ILogger<GetArtists> _logger;

        public GetArtists(ILogger<GetArtists> logger)
        {
            _logger = logger;
        }

        [Function("GetArtists")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
        {
            _logger.LogInformation("Get artists");

            var artists = new List<Artist>()
            {
                new Artist()
                {
                    Id = 1,
                    Name = "Draconian",
                    Image = "woodstock.jpg",
                    ScheduleItems = new List<ScheduleItem>()
                    {
                        new ScheduleItem()
                        {
                            Artist = new Artist()
                            {
                                Id = 1,
                                Name = "Draconian",
                            },
                            ArtistId = 1,
                            Id = 127,
                            Stage = new Stage()
                            {
                                Id = 786,
                                Name = "Mainstage"
                            },
                            StageId = 786,
                            Time = DateTime.Now,
                        }
                    }
                }
            };
            return new OkObjectResult(artists);
        }
    }
}
