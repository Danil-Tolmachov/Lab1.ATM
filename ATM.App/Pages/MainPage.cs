using ATM.DesktopApp.Interfaces;
using ATM.DesktopApp.Utils;
using ATM.Logic.Interfaces;

namespace ATM.DesktopApp.Pages;

public class MainMenuPage : IWinFormsPage
{
    private Panel _pagePanel;
    private readonly IAuthService _authService;
    private readonly ATMForm.ShowPageDelegate _showPage;
    private Label mainMenuLabel;

    public Panel PagePanel => _pagePanel;
    public string CurrentActionName { get; set; }

    public MainMenuPage(Panel mainMenuPanel, IAuthService authService, ATMForm.ShowPageDelegate showPage)
    {
        _pagePanel = mainMenuPanel;
        _authService = authService;
        _showPage = showPage;
    }

    public void InitializePage() 
    {
        mainMenuLabel = RenderHelper.FindControlOnPanel<Label>("mainMenuLabel", _pagePanel);
        if (mainMenuLabel != null) 
        {
            mainMenuLabel.Text = $"Welcome, {_authService.GetCurrentUser()?.Name}!";
        }
    }

    public Dictionary<string, Action> GetActions()
    {
        return new Dictionary<string, Action>()
        {
            { "Balance", PerformBalance },
            { "OperationHistory", PerformOperationHistory },
            { "NearAtms", PerformNearAtms },
            { "GoBack", PerformGoBack }
        };
    }

    private void PerformBalance()
    {
        _showPage("Balance");
    }

    private void PerformOperationHistory()
    {
        _showPage("OperationHistory");
    }

    private void PerformNearAtms()
    {
        _showPage("NearAtms");
    }

    private void PerformGoBack()
    {
        _showPage("Login", true);
    }
}
