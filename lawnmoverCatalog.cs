
internal class ManualawnmoverCatalog : IlawnmoverCatalog
{
    public LawnMover[] getLawnmovers() => new LawnMover[] 
    {
            new LawnMover{ Lname="manual lawnmover", price=44},
            new LawnMover{ Lname="manual lawnmover1", price=424},
        };

}

internal class ElecawnmoverCatalog : IlawnmoverCatalog
{
    public LawnMover[] getLawnmovers() => new LawnMover[] 
    {
            new LawnMover{ Lname="elec lawnmover", price=44},
            new LawnMover{ Lname="elec lawnmover1", price=424},
        };

}

internal class petrolawnmoverCatalog : IlawnmoverCatalog
{
    public LawnMover[] getLawnmovers() => new LawnMover[] 
    {
            new LawnMover{ Lname="petrol lawnmover", price=44},
            new LawnMover{ Lname="petrol lawnmover1", price=424},
        };

}
public interface IlawnmoverCatalog{
    LawnMover[] getLawnmovers();
}
