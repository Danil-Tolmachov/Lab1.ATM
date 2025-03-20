namespace ATM.DesktopApp.Interfaces;

public interface IWinFormsPage
{
    Panel PagePanel { get; }

    string CurrentActionName { get; set; }

    void InitializePage();

    Dictionary<string, Action> GetActions();
}