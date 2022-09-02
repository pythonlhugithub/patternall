using Microsoft.AspNetCore.Mvc;
using sss;

namespace singto.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

IUserManager _um;
   
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    //private readonly IlawnmoverCatalog _lmcatalog;   not the single, 

      private readonly IlawnmoverCatalog _lmcatalog;  //must multiple interface []


    public WeatherForecastController(ILogger<WeatherForecastController> logger,IUserManager um, IlawnmoverCatalog lmcatalog)
    {
        _logger = logger;
         _um=um;
         _lmcatalog=lmcatalog;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get(string typ)
    {
        
        //here _lmcatalog is a collection of three classes type, so we need to get class name in here to distinguish

       
        // foreach(var eachclass in _lmcatalog){

        //     if(eachclass.GetType().Name.Contains(typ)) Console.WriteLine(eachclass.getLawnmovers());

        // }
        // now foe=reach is loop interfaces[], this can be refactor as a factory




// var users=UserManager.Instance.UseName; //single manager can not be mount
// Console.WriteLine(users); //but use injection


 var users=_um.UseName; //single manager can not be mount
Console.WriteLine(users.FirstOrDefault()); //but use injection



        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
