using ATM.DesktopApp.Interfaces;
using ATM.DesktopApp.Utils;
using ATM.Logic.Interfaces;
using ATM.Logic.Models;

namespace ATM.DesktopApp.Pages;
public class WithdrawPage : IWinFormsPage
{
    private Panel _pagePanel;
    private readonly IAuthService _authService;
    private readonly IBankService _bankService;
    private readonly ATMForm.ShowPageDelegate _showPage;
    private TextBox withdrawTextBox;

    public Panel PagePanel => _pagePanel;
    public string CurrentActionName { get; set; }

    public WithdrawPage(Panel pagePanel, IAuthService authService, IBankService bankService, ATMForm.ShowPageDelegate showPage)
    {
        _pagePanel = pagePanel;
        _authService = authService;
        _bankService = bankService;
        _showPage = showPage;
    }

    public void InitializePage()
    {
        CurrentActionName = "Withdraw";
        withdrawTextBox = RenderHelper.FindControlOnPanel<TextBox>("withdrawTextBox", _pagePanel);
        if (withdrawTextBox != null)
        {
            withdrawTextBox.Text = string.Empty;
            withdrawTextBox.Focus();
        }
    }

    public Dictionary<string, Action> GetActions()
    {
        return new Dictionary<string, Action>()
        {
            { "Withdraw", PerformWithdraw },
            { "GoBack", PerformGoBack }
        };
    }

    private void PerformWithdraw()
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

            if (!decimal.TryParse(withdrawTextBox.Text, out decimal result))
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _showPage("Withdraw", true);
                return;
            }

            _bankService.Withdraw(user.Id, result);
            _showPage("Balance");
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _showPage("Withdraw", true);
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _showPage("Withdraw", true);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Unexpected error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _showPage("Withdraw", true);
        }
    }

    private void PerformGoBack()
    {
        _showPage("Balance");
    }
}
