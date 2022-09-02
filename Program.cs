


using singto.Controllers;
using sss;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IUserManager,UserManager>();


builder.Services.AddSingleton<ILawnMoverCatelogFactory, LawnMoverCatelogFactory>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


var emailvisitor=new Emailvisitor();
var textvisitor=new Textvisitor();

var goovisitor=new Goovisitor();

var invoice=new InvoiceNotificationSender();
invoice.Send("invoice message to send");  //send by invoice
invoice.Accept(emailvisitor);
invoice.Send("invoice");

var market=new MarketNotificationSender();
market.Send("market message to send");  //send by market
market.Accept(emailvisitor);
market.Accept(goovisitor);
market.Send("market");  //visitor parrtern


var cat=new Emailcart();
cat.Checkout();

var tcar=new texEmailcart();
tcar.Checkout();



var iteminf=new ItemValator();
var payme=new Payme();

var emailrpt=new emaulSendRecpt();
var txtrpt=new textsentt();

var cartsolid=new SolidCart(iteminf, payme, emailrpt);//interface can be passed its class for para.
cartsolid.Checkout();

var tcartsolid=new SolidCart(iteminf, payme, txtrpt);
tcartsolid.Checkout();




app.Run();

