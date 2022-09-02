
namespace ccxx;
public class CarFactory : ICarFactory{
    private readonly IDictionary<string , ICar> cars=new  Dictionary<string , ICar>()   ;

public ICar Getcar(string type){
    if(cars.ContainsKey(type)) return cars[type];
    var car=createCar(type);
    return car;

}

private ICar createCar(string type)=>
type switch
{
"Bmw"=>new BmwCar("v8","red"),
"Audi"=>new AudiCar("v8","red"),
_=> throw new ArgumentException("invalid choice ")
};


}