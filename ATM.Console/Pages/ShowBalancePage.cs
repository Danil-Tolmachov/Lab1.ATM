using ATM.ConsoleApp.Interfaces;
using ATM.Logic.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ATM.ConsoleApp.Pages;

public class ShowBalancePage(IServiceProvider serviceProvider) : IPage
{
    private readonly IAuthService _authService = serviceProvider.GetService<IAuthService>()
        ?? throw new ArgumentNullException(nameof(serviceProvider), "Failed to retrieve service.");

    private readonly IBankService _bankService = serviceProvider.GetService<IBankService>()
        ?? throw new ArgumentNullException(nameof(serviceProvider), "Failed to retrieve service.");

    public string GetHeader()
    {
        var user = _authService.GetCurrentUser()
            ?? throw new ArgumentException("User is not authorized.");

        var balance = _bankService.GetBalance(user.Id);

        return $"Balance of \"{user?.Name}\" account is - {balance}";
    }

    public Dictionary<ConsoleKey, ApplicationAction> GetActions()
    {
        return new() 
        {
            { ConsoleKey.F1, new("Withdraw cash.", Withdraw, null) },
            { ConsoleKey.F2, new("Deposit cash.", Deposit, null) },
            { ConsoleKey.F3, new("Send cash to another card.", Send, null) },
        };
    }

    private void Withdraw()
    {
        var user = _authService.GetCurrentUser()
            ?? throw new ArgumentException("User is not authorized.");

        Console.Clear();
        Console.Write("Ammount to withdraw: ");
        var ammount = Console.ReadLine();

        if (!decimal.TryParse(ammount,  out decimal result))
        {
            throw new InvalidOperationException("Invalid input.");
        }

        _bankService.Withdraw(user.Id, result);
    }

    private void Deposit()
    {
        var user = _authService.GetCurrentUser()
            ?? throw new ArgumentException("User is not authorized.");

        Console.Clear();
        Console.Write("Ammount to deposit: ");
        var ammount = Console.ReadLine();

        if (!decimal.TryParse(ammount, out decimal result))
        {
            throw new InvalidOperationException("Invalid input.");
        }

        _bankService.Deposit(user.Id, result);
    }

    private void Send()
    {
        var user = _authService.GetCurrentUser()
            ?? throw new ArgumentException("User is not authorized.");

        Console.Clear();

        Console.Write("Card number, to which cash will be sent: ");
        var cardNumber = Console.ReadLine();

        Console.Write("Ammount to send: ");
        var ammount = Console.ReadLine();

        if (!decimal.TryParse(ammount, out decimal result)
            && string.IsNullOrEmpty(cardNumber))
        {
            throw new InvalidOperationException("Invalid input.");
        }

        _bankService.SendToAccount(user.Id, cardNumber ??  string.Empty, result);
    }
}
