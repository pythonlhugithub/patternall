


internal class Emailcart : TemplateCart
{
    protected override void SendReceipts()
    {
        Console.WriteLine("email sent");
    }
}


internal class texEmailcart : TemplateCart
{
    protected override void SendReceipts()
    {
        Console.WriteLine("text sent");
    }
}