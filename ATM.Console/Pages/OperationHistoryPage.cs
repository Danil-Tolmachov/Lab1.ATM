using ATM.ConsoleApp.Interfaces;
using ATM.Logic.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Text;

namespace ATM.ConsoleApp.Pages;

public class OperationHistoryPage(IServiceProvider serviceProvider) : IPage
{
    private readonly IAuthService _authService = serviceProvider.GetService<IAuthService>()
        ?? throw new ArgumentNullException(nameof(serviceProvider), "Failed to retrieve service.");

    public string GetHeader()
    {
        var user = _authService.GetCurrentUser();

        var sb = new StringBuilder("Operations:\n\n");

        foreach (var transaction in user?.Transactions ?? [])
        {
            sb.AppendLine($"[{transaction.Time}]: {transaction.Ammount}");
        }

        return sb.ToString();
    }

    public Dictionary<ConsoleKey, ApplicationAction> GetActions()
    {
        return new();
    }
}
