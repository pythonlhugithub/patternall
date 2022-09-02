
public class User : IUser
{
 
    private string? _name;
    private int _age;  //set not get so never access
    private string? _address;

    public User()
    {
        
    }
public User(string name,  string address)
    {
        _name=name;
        _address=address;
    }

    public string name  {get {return _name;}}

    public int age { set  {age=value;} }

    public string address  {get {return _address;}}

    public object Clone()
    {
        return this.MemberwiseClone(); //show copy object
    }
    // public string name {get{return _name;}}

    // public int age { set{age=value;} }

    // public string address  {get {return _address;}}
}

public interface IUser : ICloneable{

string name {get;}
int age {set;}

string address{get;}

}