using ATM.DesktopApp.Interfaces;
using ATM.DesktopApp.Utils;
using ATM.Logic.Interfaces;
using ATM.Logic.Models;

namespace ATM.DesktopApp.Pages;
public class DepositPage : IWinFormsPage
{
    private Panel _pagePanel;
    private readonly IAuthService _authService;
    private readonly IBankService _bankService;
    private readonly ATMForm.ShowPageDelegate _showPage;
    private TextBox depositTextBox;

    public Panel PagePanel => _pagePanel;
    public string CurrentActionName {  get; set; }

    public DepositPage(Panel pagePanel, IAuthService authService, IBankService bankService, ATMForm.ShowPageDelegate showPage)
    {
        _pagePanel = pagePanel;
        _authService = authService;
        _bankService = bankService;
        _showPage = showPage;
    }

    public void InitializePage()
    {
        CurrentActionName = "Deposit";
        depositTextBox = RenderHelper.FindControlOnPanel<TextBox>("depositTextBox", _pagePanel);
        if (depositTextBox != null)
        {
            depositTextBox.Text = string.Empty;
            depositTextBox.Focus();
        }
    }

    public Dictionary<string, Action> GetActions()
    {
        return new Dictionary<string, Action>()
        {
            { "Deposit", PerformDeposit },
            { "GoBack", PerformGoBack }
        };
    }

    private void PerformDeposit()
    {
        Account user = null;

        try
        {
            user = _authService.GetCurrentUser();

            if (user == null)
            {
                MessageBox.Show("User is not authorized", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _showPage("Login", true);
                return;
            }

            if (!decimal.TryParse(depositTextBox.Text, out decimal result))
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _showPage("Deposit", true);
                return;
            }

            _bankService.Deposit(user.Id, result);
            _showPage("Balance");
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _showPage("Deposit", true);
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _showPage("Deposit", true);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Unexpected error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _showPage("Deposit", true);
        }
    }

    private void PerformGoBack()
    {
        _showPage("Balance");
    }
}
