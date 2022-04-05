using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Kaustubh","Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        var abc = new List<WeatherForecast>();

        for(int i=0; i<Summaries.Count(); i++){
            var b = new WeatherForecast(){
                Date = DateTime.Now.AddDays(i),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[i]
            };

            abc.Add(b);

        }
        return abc.ToList();
    }
}
