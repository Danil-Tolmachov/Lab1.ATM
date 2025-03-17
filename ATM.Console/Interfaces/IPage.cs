namespace ATM.ConsoleApp.Interfaces;

public interface IPage
{
    string GetHeader();

    Dictionary<ConsoleKey, ApplicationAction> GetActions();
}
