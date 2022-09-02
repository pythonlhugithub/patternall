public interface InotificationSender{
    void Send(string message);  //can send email, send text, etc.
   // void setupemail();  //because we not change both, so we remove both and put it to visitor
   // void setuptext();
void Accept(IVisitor visitor);// ask visitor to do setup email, set up text, notificaiton sender does not need todo

//so visitor can do more in its own class, such as websocket notifi. create websortket sender.....

//but notifisender need to accept this visitor object

//so notifisneder know this visitor


}

public interface IVisitor{
void visit(InotificationSender notifsnedr); 

 //visit call sneder to get send() get accept()

 //accept call itself in visitor class???!!!
 
}