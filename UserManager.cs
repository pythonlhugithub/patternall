
namespace sss;
public class UserManager:IUserManager{

  private string[] _UseName ;
    public  UserManager() //singleton 
    {
        _UseName=new [] {"dfd","dfd","fddfd","yser1"};
    }
  
    // private static readonly Lazy<UserManager> instance
    // =new Lazy<UserManager>(()=>new UserManager()); //create by class itself

    // public static UserManager Instance=instance.Value; //pass private instance to public.   ---singleton is hard to test, so both used injection, should be disab;led

    public string[] UseName =>_UseName;


}

public interface IUserManager
{
string[] UseName{get;}

}