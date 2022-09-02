public class Notifiowner : Inotifiowner
{
    public void send(string message)
    {
         Console.WriteLine($"send message : {message}");
    }

  public void setupemail()
    {
        Console.WriteLine("set up email");
    }

    public void setuptext()
    {
        Console.WriteLine("set up text");
    }
}


public interface Inotifiowner {

void send(string message);

void setupemail();
void setuptext();

}