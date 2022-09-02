
namespace singto.Controllers;

public interface ILawnMoverCatelogFactory
{
    IlawnmoverCatalog CreateCatelog (string type);
}