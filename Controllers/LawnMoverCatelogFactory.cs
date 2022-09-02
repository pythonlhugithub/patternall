
namespace singto.Controllers;
public class LawnMoverCatelogFactory : ILawnMoverCatelogFactory {
    public IlawnmoverCatalog CreateCatelog (string type){
    return type switch{
        "petrol"=>new petrolawnmoverCatalog(),
        "ele"=>new ElecawnmoverCatalog(),
        _=>new ManualawnmoverCatalog()
    };

    }
}
