public class Emailvisitor : IVisitor
{

    // private Notifiowner notiow;
    //     public visitor(Notifiowner notiow)
    //     {
    //         this.notiow=notiow;
    //     }

    //      void setupemail(){;}  //because we not change both, so we remove both and put it to visitor
    //     void setuptext(){;}
    public void visit(InotificationSender notifsnedr)  //replace sendeamil()
    {
         Console.WriteLine("set up email");
    }
}


public class Textvisitor : IVisitor
{

    // private Notifiowner notiow;
    //     public visitor(Notifiowner notiow)
    //     {
    //         this.notiow=notiow;
    //     }

    //      void setupemail(){;}  //because we not change both, so we remove both and put it to visitor
    //     void setuptext(){;}
    public void visit(InotificationSender notifsnedr)  //replace sendeamil()
    {
         Console.WriteLine("set up text");
    }
}


public class Goovisitor : IVisitor
{

    // private Notifiowner notiow;
    //     public visitor(Notifiowner notiow)
    //     {
    //         this.notiow=notiow;
    //     }

    //      void setupemail(){;}  //because we not change both, so we remove both and put it to visitor
    //     void setuptext(){;}
    public void visit(InotificationSender notifsnedr)  //replace sendeamil()
    {
         Console.WriteLine("set up google"); //similiar methods can be absctracted to one visit (); then deploy here.

         notifsnedr.Send("visit top code ");
    }
}