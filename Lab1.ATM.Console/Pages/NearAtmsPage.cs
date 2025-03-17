using ATM.ConsoleApp.Interfaces;
using ATM.Logic.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Text;

namespace ATM.ConsoleApp.Pages;

public class NearAtmsPage(IServiceProvider serviceProvider) : IPage
{
    private readonly IAtmService _atmService = serviceProvider.GetService<IAtmService>()
        ?? throw new ArgumentNullException(nameof(serviceProvider), "Failed to retrieve service.");

    public string GetHeader()
    {
        var sb = new StringBuilder("Near ATMs:\n\n");

        foreach (var atm in _atmService.GetAll())
        {
            sb.AppendLine($"[ID: {atm.Id}]: Street: {atm.Address}");
        }

        return sb.ToString();
    }

    public Dictionary<ConsoleKey, ApplicationAction> GetActions()
    {
        return new();
    }
}
