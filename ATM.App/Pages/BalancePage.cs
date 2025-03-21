using ATM.DesktopApp.Interfaces;
using ATM.DesktopApp.Utils;
using ATM.Logic.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ATM.DesktopApp.Pages;

public class BalancePage : IWinFormsPage
{
    private Panel _pagePanel;
    private readonly IAuthService _authService;
    private readonly IBankService _bankService;
    private readonly ATMForm.ShowPageDelegate _showPage;
    private Label balanceLabel;

    public string CurrentActionName { get; set; }
    public Panel PagePanel => _pagePanel;

    public BalancePage(Panel balancePanel, IAuthService authService, IBankService bankService, ATMForm.ShowPageDelegate showPage)
    {
        _pagePanel = balancePanel;
        _authService = authService;
        _bankService = bankService;
        _showPage = showPage;
    }

    public void InitializePage()
    {
        balanceLabel = RenderHelper.FindControlOnPanel<Label>("balanceLabel", _pagePanel);
        if (balanceLabel != null)
        {
            balanceLabel.Text = GetBalance();
        }
    }

    private string GetBalance()
    {
        var user = _authService.GetCurrentUser();
        
        if (user == null)
        {
            MessageBox.Show("User is not authorized", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _showPage("Login", true);
        }

        var balance = _bankService.GetBalance(user.Id);

        return $"Balance of \"{user?.Name}\" account is - {balance}";
    }

    public Dictionary<string, Action> GetActions()
    {
        return new Dictionary<string, Action>()
        {
            { "Deposit", PerformDepositAction },
            { "Withdraw", PerformWithdrawAction },
            { "SendToCard", PerformSendToCardAction },
            { "GoBack", PerformGoBack }
        };
    }
    
    private void PerformDepositAction()
    {
        _showPage("Deposit", true);
    }

    private void PerformWithdrawAction() 
    {
        _showPage("Withdraw", true);
    }

    private void PerformSendToCardAction() 
    {
        _showPage("SendToCard", true);
    }

    private void PerformGoBack()
    {
        _showPage("MainMenu");
    }
}
