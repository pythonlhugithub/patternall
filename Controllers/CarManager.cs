namespace ccxx;
public class CarManager : ICarManager {
    private readonly ICar car;
private decimal lat=0;
private decimal lon=0;
public CarManager(ICarFactory icarfac, string type)
{
    car=icarfac.Getcar(type);
}

public void setlocation (decimal lat,decimal lon){

    this.lat=lat;
    this.lon=lat;

    car.SetLocation(lat,lon);

}
}