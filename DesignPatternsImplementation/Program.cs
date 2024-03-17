using DesignPatternsImplementation.Creationals.FactoryMethod.Clientes;
using DesignPatternsImplementation.Creationals.FactoryMethod.Creators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var factory = new LandMailFactory();
var client = new Client(factory);
client.SendParcel();

app.Run();