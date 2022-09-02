namespace ccxx;

public class AudiCar : ICar
{
    public AudiCar()
    {
        
    }
    public AudiCar(string color, string engine)
    {
        this.color=color;
        this.engine=engine;
    }
    public string color { get {return this .color;}  set {this.color=value;} }
    public string engine  { get {return this .color;}  set {this.engine=value;} }

    public void SetLocation(decimal lat, decimal lon)
    {
        Console.WriteLine($"color: {color}, engine: {engine}, location: {lat}-{lon}");
    }
}