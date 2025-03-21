using ATM.DesktopApp.Interfaces;
using ATM.DesktopApp.Utils;
using ATM.Logic;
using ATM.Logic.Interfaces;
using System.Text;

namespace ATM.DesktopApp.Pages;
public class OperationHistoryPage : IWinFormsPage
{
    private Panel _pagePanel;
    private readonly IAuthService _authService;
    private readonly ATMForm.ShowPageDelegate _showPage;
    private Label operationHistoryLabel;
    private Label operationHistoryInfoLabel;

    public Panel PagePanel => _pagePanel;
    public string CurrentActionName {  get; set; }

    public OperationHistoryPage(Panel panel, IAuthService authService, ATMForm.ShowPageDelegate showPage)
    {
        _pagePanel = panel;
        _authService = authService;
        _showPage = showPage;
    }

    public void InitializePage()
    {
        operationHistoryInfoLabel = RenderHelper.FindControlOnPanel<Label>("historyInfoLabel", _pagePanel);
        operationHistoryLabel = RenderHelper.FindControlOnPanel<Label>("historyLabel", _pagePanel);
        operationHistoryLabel.Text = "Operation History";
        operationHistoryInfoLabel.Text = GetOperationHistory();
    }

    private string GetOperationHistory()
    {
        var user = _authService.GetCurrentUser();

        if (user == null) 
        {
            MessageBox.Show("User is not authorized", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _showPage("Login", true);
        }

        var sb = new StringBuilder("Operations:\n\n");

        foreach (var transaction in user?.Transactions ?? [])
        {
            sb.AppendLine($"[{transaction.Time}]: {transaction.Ammount}");
        }

        return sb.ToString();
    }

    public Dictionary<string, Action> GetActions()
    {
        return new Dictionary<string, Action>()
        {
            { "GoBack", PerformGoBack }
        };
    }

    private void PerformGoBack()
    {
        _showPage("MainMenu");
    }
}
