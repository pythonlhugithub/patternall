public class MarketNotificationSender : InotificationSender
{
    public void Accept(IVisitor visitor)
    {
        visitor.visit(this); //associate caller
    }

    public void Send(string message)
    {
        Console.WriteLine($"market send message : {message}");
    }

    // public void setupemail()
    // {
    //     Console.WriteLine("set up email");
    // }

    // public void setuptext()
    // {
    //     Console.WriteLine("set up text");
    // }
}