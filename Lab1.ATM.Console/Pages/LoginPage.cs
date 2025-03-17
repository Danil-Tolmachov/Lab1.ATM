using ATM.ConsoleApp.Interfaces;
using ATM.Logic.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ATM.ConsoleApp.Pages;

public class LoginPage(IServiceProvider serviceProvider) : IPage
{
    private readonly IAuthService _authService = serviceProvider.GetService<IAuthService>()
        ?? throw new ArgumentNullException(nameof(serviceProvider), "Failed to retrieve service.");

    public string GetHeader()
    {
        return "Welcome!";
    }

    public Dictionary<ConsoleKey, ApplicationAction> GetActions()
    {
        return new()
        {
            { ConsoleKey.F1, new("Login", Login, new MainPage(serviceProvider)) },
        };
    }

    private void Login()
    {
        Console.Clear();

        Console.Write("Enter your card number: ");
        var cardNumber = Console.ReadLine();

        Console.Write("Enter your PIN: ");
        var pin = Console.ReadLine();

        if (cardNumber == null || pin == null)
        {
            Console.Clear();
            Console.Write("Invalid input...");
            Thread.Sleep(1000);

            throw new InvalidOperationException("Invalid input.");
        }

        var user = _authService.Login(cardNumber, pin);

        if (user == null)
        {
            Console.Clear();
            Console.Write("Failed to authorize...");
            Thread.Sleep(1000);

            throw new InvalidOperationException("Failed to authorize user.");
        }
    }
}
