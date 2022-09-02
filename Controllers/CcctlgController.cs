using Microsoft.AspNetCore.Mvc;
 

namespace singto.Controllers;

[ApiController]
[Route("[controller]")]
public class CcctlgController : ControllerBase
{
 
       private readonly ILogger<WeatherForecastController> _logger;
private readonly ILawnMoverCatelogFactory _lmcatalog; 
private readonly IUser _user; 
public CcctlgController(IUser user,ILawnMoverCatelogFactory lmcatalog, ILogger<WeatherForecastController> logger)
{
    //_user=new User("david h", "sss street");
//_user=new User(user.name,user.address); //never get value from object. 
//use prototype desing pattern 

_user=user.Clone() as IUser;  //structure clone
    _lmcatalog=lmcatalog;
    _logger=logger;
}

[HttpGet]

public IUser Get(){


    return _user;  //structure only
}
    
//     [HttpGet(Name = "Gft")]
//     public LawnMover[] Get(string typ)
//     {
        
//         //here _lmcatalog is a collection of three classes type, so we need to get class name in here to distinguish

 
       
//    var ccc=    _lmcatalog.CreateCatelog(typ).getLawnmovers(); //now we know hot wo create factory for this
        

// return ccc;

// // var users=UserManager.Instance.UseName; //single manager can not be mount
// // Console.WriteLine(users); //but use injection


//     }
}
