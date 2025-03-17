using ATM.ConsoleApp.Interfaces;
using ATM.Logic.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ATM.ConsoleApp.Pages;

public class MainPage(IServiceProvider serviceProvider) : IPage
{
    private readonly IAuthService _authService = serviceProvider.GetService<IAuthService>()
        ?? throw new ArgumentNullException(nameof(serviceProvider), "Failed to retrieve service.");

    public string GetHeader()
    {
        return $"Welcome, {_authService.GetCurrentUser()?.Name}!";
    }

    public Dictionary<ConsoleKey, ApplicationAction> GetActions()
    {
        return new()
        {
            { ConsoleKey.F1, new("Show balance.", () => {}, new ShowBalancePage(serviceProvider)) },
            { ConsoleKey.F2, new("Operation history.", () => {}, new OperationHistoryPage(serviceProvider)) },
            { ConsoleKey.F3, new("Show near ATMs.", () => {}, new NearAtmsPage(serviceProvider)) },
        };
    }
}
