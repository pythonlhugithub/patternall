using Microsoft.AspNetCore.Mvc;
 using ccxx;

namespace singto.Controllers;

[ApiController]
[Route("[controller]")]
public class CarController : ControllerBase
{

      private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

 private readonly ILogger<WeatherForecastController> _logger;
private readonly ICarManager[] carmanagers;
public CarController( ICarManager[] carmanagers,ILogger<WeatherForecastController> logger)
{
_logger=logger;
this.carmanagers=carmanagers;

}

[HttpGet]
public string Get(){


    
decimal lat=1;
decimal lon=1;
foreach(var carmanager in carmanagers)  //now we need to create [] list, do in addsinglton way
{
    carmanager.setlocation(lat++,lon++);

    

}



 return "test ok";



}


}


