
internal abstract class TemplateCart{
    public void Checkout(){
        
        ValidateItems();
        ExecutePayment();
        SendReceipts();
    }

     protected abstract void SendReceipts(); //because it is used by other inherit class, so abstract
    

    private void ExecutePayment()
    {
         Console.WriteLine("payment executed");
    }

    private void ValidateItems()
    {
          Console.WriteLine("items validated");
    }
}