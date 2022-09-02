public class InvoiceNotificationSender : InotificationSender
{
    public InvoiceNotificationSender()
    {
    }

    public void Accept(IVisitor visitor)  //new deploy
    {
        visitor.visit(this);  //just for accept visitor object, do nothing in method
    }

    public void Send(string message)
    {
        Console.WriteLine($"send message : {message}");
    }

    // public void setupemail()   //now i want to sent web, send fire, method will be added here, no!!! we need to refactor this without change those two methods.

    // {
    //     Console.WriteLine("set up email");
    // }

    // public void setuptext()
    // {
    //     Console.WriteLine("set up text");
    // }
}