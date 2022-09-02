internal class SolidCart {

private IItemValator itemv; 
private IPayme paye;
private ISendRecpt senpt;

    public SolidCart(IItemValator itemv, IPayme paye, ISendRecpt senpt)
    {
        this.itemv=itemv;
         this.paye=paye; 
         this.senpt=senpt;
    }

    internal void Checkout(){

        itemv.ValidateItems();
        paye.ExecutePayment();
        senpt.SendReceipts();

    }
}

public interface IItemValator {

    void ValidateItems();
 
}

internal class ItemValator : IItemValator
{
    public void ValidateItems()
    {
        Console.WriteLine("item validated ---");
    }
}


public interface IPayme {

    
    void    ExecutePayment();
 
}

internal class Payme : IPayme
{
    public void ExecutePayment()
    {
        Console.WriteLine("payment item validated ---");
    }
}
 
public interface ISendRecpt {

      void        SendReceipts();
}

internal class emaulSendRecpt : ISendRecpt
{
    public void SendReceipts()
    {
        Console.WriteLine("email item sent ---");
    }
}

internal class textsentt : ISendRecpt
{
    public void SendReceipts()
    {
        Console.WriteLine("text  item sent ---");
    }
}

