namespace ccxx;
public interface ICar{
    public string color{get;set;}
    public string engine{get;set;}
    void SetLocation(decimal lat, decimal lon);
}