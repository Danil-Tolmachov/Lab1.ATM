using ATM.DesktopApp.Interfaces;
using ATM.DesktopApp.Utils;
using ATM.Logic.Interfaces;
using ATM.Logic.Models;

namespace ATM.DesktopApp.Pages;

public class LoginPage : IWinFormsPage
{
    private Panel _pagePanel;
    private readonly IAuthService _authService;
    private readonly ATMForm.ShowPageDelegate _showPage;
    private Label loginLabel;
    private TextBox loginTextBox;
    private string cardNumber;

    public Panel PagePanel => _pagePanel;
    public string CurrentActionName { get; set; }

    public LoginPage(Panel loginPanel,  IAuthService authService, ATMForm.ShowPageDelegate showPage)
    {
        _pagePanel = loginPanel;
        _authService = authService;
        _showPage = showPage;
    }

    public void InitializePage()
    {
        CurrentActionName = "Login";
        loginLabel = RenderHelper.FindControlOnPanel<Label>("textLabel", _pagePanel);
        loginTextBox = RenderHelper.FindControlOnPanel<TextBox>("inputTextBox", _pagePanel);
        if (loginTextBox != null && loginLabel != null) 
        {
            loginTextBox.Text = string.Empty;
            loginTextBox.PasswordChar = '\0';
            loginLabel.Text = "Enter card number";
        }
    }

    public Dictionary<string, Action> GetActions()
    {
        return new Dictionary<string, Action>()
        {
            { "Login", PerformLoginAction }
        };
    }

    private void PerformLoginAction()
    {
        try
        {
            if (loginTextBox.PasswordChar == '\0')
            {
                cardNumber = loginTextBox.Text;
                loginTextBox.Text = string.Empty;
                loginLabel.Text = "Enter PIN";
                loginTextBox.PasswordChar = '*';
            }

            else
            {
                if (cardNumber == null || loginTextBox.Text == null)
                {
                    MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _showPage("Login", true);
                    return;
                }

                Account user = null;

                user = _authService.Login(cardNumber, loginTextBox.Text);

                if (user == null)
                {
                    MessageBox.Show("Failed to authorize user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginTextBox.PasswordChar = '\0';
                    _showPage("Login", true);
                }
                else
                {
                    _showPage("MainMenu");
                }
            }
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _showPage("SendToCard", true);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Unexpected error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _showPage("SendToCard", true);
        }
    }
}
