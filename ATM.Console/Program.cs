using ATM.ConsoleApp;
using ATM.Logic;
using ATM.Logic.Interfaces;
using ATM.Logic.Services;
using Microsoft.Extensions.DependencyInjection;

var builder = new ServiceCollection();

builder.AddSingleton<MockDatabase>();
builder.AddSingleton<IAuthService, AuthService>();
builder.AddSingleton<IBankService, BankService>();
builder.AddScoped<IAtmService, AtmService>();

var services = builder.BuildServiceProvider();

// Configure event messages.
{
    var bankService = services.GetRequiredService<IBankService>();
    var authService = services.GetRequiredService<IAuthService>();

    bankService.OnDeposit += () =>
    {
        Console.Clear();
        Console.WriteLine("New Message!");
        Thread.Sleep(2000);
    };

    bankService.OnWithdraw += () =>
    {
        Console.Clear();
        Console.WriteLine("New Message!");
        Thread.Sleep(2000);
    };

    bankService.OnSendToAccount += () =>
    {
        Console.Clear();
        Console.WriteLine("New Message!");
        Thread.Sleep(2000);
    };

    authService.OnLogin += () =>
    {
        Console.Clear();
        Console.WriteLine("New Message!");
        Thread.Sleep(2000);
    };
}


var app = new ConsoleApp(services);

app.Run();
