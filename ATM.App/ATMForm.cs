using ATM.Logic;
using ATM.Logic.Models;
using ATM.Logic.Services;
using System.Text;
using System.Xml.Linq;

namespace ATM.DesktopApp;

public partial class ATMForm : Form
{
    private MockDatabase _mockDatabase;
    private AuthService _authService;
    private AtmService _atmService;
    private BankService _bankService;
    private Panel _currentVisiblePanel;
    public ATMForm()
    {
        InitializeComponent();

        _mockDatabase = new MockDatabase();
        _authService = new AuthService(_mockDatabase);
        _atmService = new AtmService(_mockDatabase);
        _bankService = new BankService(_mockDatabase);

        ShowLoginPage();
    }

    private void ShowLoginPage()
    {
        loginPanel.Visible = true;
        mainMenuPanel.Visible = false;
        balancePanel.Visible = false;
        withdrawPanel.Visible = false;
        depositPanel.Visible = false;
        sendToCardPanel.Visible = false;
        historyPanel.Visible = false;
        nearAtmsPanel.Visible = false;
        keyBoardPanel.Visible = true;
        _currentVisiblePanel = loginPanel;

        textLabel.Text = "Enter your card number";
    }

    private void ShowMainMenuPage()
    {
        loginPanel.Visible = false;
        mainMenuPanel.Visible = true;
        balancePanel.Visible = false;
        withdrawPanel.Visible = false;
        depositPanel.Visible = false;
        sendToCardPanel.Visible = false;
        historyPanel.Visible = false;
        nearAtmsPanel.Visible = false;
        keyBoardPanel.Visible = false;
        _currentVisiblePanel = mainMenuPanel;
        mainMenuLabel.Text = $"Welcome, {_authService.GetCurrentUser()?.Name}!";
    }

    private void ShowBalancePage()
    {
        loginPanel.Visible = false;
        mainMenuPanel.Visible = false;
        balancePanel.Visible = true;
        withdrawPanel.Visible = false;
        depositPanel.Visible = false;
        sendToCardPanel.Visible = false;
        historyPanel.Visible = false;
        nearAtmsPanel.Visible = false;
        keyBoardPanel.Visible = false;
        _currentVisiblePanel = balancePanel;
        balanceLabel.Text = GetBalance();
    }

    private void ShowWithdrawPage()
    {
        loginPanel.Visible = false;
        mainMenuPanel.Visible = false;
        balancePanel.Visible = false;
        withdrawPanel.Visible = true;
        depositPanel.Visible = false;
        sendToCardPanel.Visible = false;
        historyPanel.Visible = false;
        nearAtmsPanel.Visible = false;
        keyBoardPanel.Visible = true;
        _currentVisiblePanel = withdrawPanel;
    }

    private void ShowDepositPage()
    {
        loginPanel.Visible = false;
        mainMenuPanel.Visible = false;
        balancePanel.Visible = false;
        withdrawPanel.Visible = false;
        depositPanel.Visible = true;
        sendToCardPanel.Visible = false;
        historyPanel.Visible = false;
        nearAtmsPanel.Visible = false;
        keyBoardPanel.Visible = true;
        _currentVisiblePanel = depositPanel;
    }

    private void ShowSendToCardPanel()
    {
        loginPanel.Visible = false;
        mainMenuPanel.Visible = false;
        balancePanel.Visible = false;
        withdrawPanel.Visible = false;
        depositPanel.Visible = false;
        sendToCardPanel.Visible = true;
        historyPanel.Visible = false;
        nearAtmsPanel.Visible = false;
        keyBoardPanel.Visible = true;
        _currentVisiblePanel = sendToCardPanel;
        sendToCardLabel.Text = "Enter Card Number";
    }

    private void ShowOperationHistoryPage()
    {
        loginPanel.Visible = false;
        mainMenuPanel.Visible = false;
        balancePanel.Visible = false;
        withdrawPanel.Visible = false;
        depositPanel.Visible = false;
        sendToCardPanel.Visible = false;
        historyPanel.Visible = true;
        nearAtmsPanel.Visible = false;
        keyBoardPanel.Visible = false;
        _currentVisiblePanel = historyPanel;
        historyInfoLabel.Text = GetOperationHistory();
    }

    private void ShowNearAtmsPage()
    {
        loginPanel.Visible = false;
        mainMenuPanel.Visible = false;
        balancePanel.Visible = false;
        withdrawPanel.Visible = false;
        depositPanel.Visible = false;
        sendToCardPanel.Visible = false;
        historyPanel.Visible = false;
        nearAtmsPanel.Visible = true;
        keyBoardPanel.Visible = false;
        _currentVisiblePanel = nearAtmsPanel;
        nearAtmInfoLabel.Text = GetNearAtms();
    }

    private T FindControlOnCurrentPanel<T>(string controlName) where T : Control
    {
        return _currentVisiblePanel?.Controls.OfType<T>().FirstOrDefault(c => (string)c.Tag == controlName);
    }

    private void buttonDigit1_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = FindControlOnCurrentPanel<TextBox>("inputTextBox");

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '1';
        }
    }

    private void buttonDigit2_Click(object sender, EventArgs e)
    {

        TextBox currentInputTextBox = FindControlOnCurrentPanel<TextBox>("inputTextBox");

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '2';
        }
    }

    private void buttonDigit3_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = FindControlOnCurrentPanel<TextBox>("inputTextBox");

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '3';
        }
    }

    private void buttonDigit4_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = FindControlOnCurrentPanel<TextBox>("inputTextBox");

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '4';
        }
    }

    private void buttonDigit5_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = FindControlOnCurrentPanel<TextBox>("inputTextBox");

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '5';
        }
    }

    private void buttonDigit6_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = FindControlOnCurrentPanel<TextBox>("inputTextBox");

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '6';
        }
    }

    private void buttonDigit7_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = FindControlOnCurrentPanel<TextBox>("inputTextBox");

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '7';
        }
    }

    private void buttonDigit8_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = FindControlOnCurrentPanel<TextBox>("inputTextBox");

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '8';
        }
    }

    private void buttonDigit9_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = FindControlOnCurrentPanel<TextBox>("inputTextBox");

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '9';
        }
    }

    private void buttonDigit0_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = FindControlOnCurrentPanel<TextBox>("inputTextBox");

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '0';
        }
    }

    private void buttonBackspace_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = FindControlOnCurrentPanel<TextBox>("inputTextBox");

        if (currentInputTextBox != null)
        {
            if (currentInputTextBox.Text.Length > 0)
            {
                currentInputTextBox.Text = currentInputTextBox.Text.Remove(currentInputTextBox.Text.Length - 1);

            }
        }
    }

    private void buttonEnter_Click(object sender, EventArgs e)
    {
        RunAction();
    }

    private void RunAction()
    {
        TextBox currentInputTextBox = FindControlOnCurrentPanel<TextBox>("inputTextBox");
        Label currentStatusLabel = FindControlOnCurrentPanel<Label>("statusLabel");

        if (_currentVisiblePanel == loginPanel)
        {
            Label currentInfoLabel = FindControlOnCurrentPanel<Label>("infoLabel");

            if (currentInputTextBox != null && currentInputTextBox.PasswordChar == '\0')
            {
                currentInfoLabel.Visible = false;
                currentInfoLabel.Text = currentInputTextBox.Text;
                currentInputTextBox.Text = string.Empty;
                currentInputTextBox.PasswordChar = '*';
                currentStatusLabel.Text = "Enter your PIN";
                currentInputTextBox.Focus();
            }
            else if (currentInputTextBox != null && currentInputTextBox.PasswordChar != '\0')
            {
                currentInputTextBox.PasswordChar = '\0';
                DataProcessing(new List<Control> { currentInputTextBox, currentInfoLabel, currentStatusLabel });
            }
            else
            {
                throw new ArgumentException("Invalid input");
            }
        }

        else if (_currentVisiblePanel == sendToCardPanel)
        {
            Label currentInfoLabel = FindControlOnCurrentPanel<Label>("infoLabel");

            if (currentInputTextBox != null)
            {
                if (currentStatusLabel.Text == "Enter Card Number")
                {
                    currentInfoLabel.Text = currentInputTextBox.Text;
                    currentInputTextBox.Text = string.Empty;
                    if (currentStatusLabel != null)
                    {
                        currentStatusLabel.Text = "Enter Amount";
                    }
                }
                else
                {
                    DataProcessing(new List<Control> { currentInputTextBox, currentInfoLabel });

                }
            }
        }

        else 
        {
            DataProcessing(new List<Control> { currentInputTextBox });
        }
    }

    private void DataProcessing(List<Control> elements)
    {
        if (_currentVisiblePanel == loginPanel)
        {
            string cardNumber = elements[1].Text;
            string pin = elements[0].Text;

            if (cardNumber == null || pin == null)
            {
                ClearElements(elements);

                throw new InvalidOperationException("Invalid input");
            }

            var user = _authService.Login(cardNumber, pin);

            if (user != null)
            {
                ClearElements(elements);
                ShowMainMenuPage();
            }
            else
            {
                elements[2].Text = "Failed to authorize...";
                elements[1].Text = "Invalid Card Number or PIN-code.";
                elements[1].Visible = true;
                ClearElements(elements);
                ShowLoginPage();

                //throw new InvalidOperationException("Failed to authorize user.");
            }
        }

        if (_currentVisiblePanel == sendToCardPanel) 
        {
            string cardNumber = elements[1].Text;
            string amount = elements[0].Text;
            ClearElements(elements);

            var user = _authService.GetCurrentUser()
                ?? throw new ArgumentException("User is not authorized");

            if (!decimal.TryParse(amount, out decimal result)
                && string.IsNullOrEmpty(cardNumber))
            {
                throw new InvalidOperationException("Invalid input");
            }

            _bankService.SendToAccount(user.Id, cardNumber ?? string.Empty, result);
            ShowBalancePage();
        }

        if (_currentVisiblePanel == withdrawPanel) 
        {
            string amount = elements[0].Text;
            ClearElements(elements);

            var user = _authService.GetCurrentUser()
                ?? throw new ArgumentException("User is not authorized");
            
            if (!decimal.TryParse(amount, out decimal result))
            {
                throw new InvalidOperationException("Invalid input");
            }

            _bankService.Withdraw(user.Id, result);
            ShowBalancePage();
        }

        if (_currentVisiblePanel == depositPanel)
        {
            string amount = elements[0].Text;
            ClearElements(elements);

            var user = _authService.GetCurrentUser()
                ?? throw new ArgumentException("User is not authorized");

            if (!decimal.TryParse(amount, out decimal result))
            {
                throw new InvalidOperationException("Invalid input");
            }

            _bankService.Deposit(user.Id, result);
            ShowBalancePage();
        }
    }

    private void ClearElements(List<Control> elements)
    {
        foreach (Control control in elements)
        {
            control.Text = string.Empty;
        }
    }

    private string GetBalance()
    {
        var user = _authService.GetCurrentUser()
            ?? throw new ArgumentException("User is not authorized");

        var balance = _bankService.GetBalance(user.Id);
        
        return $"Balance of \"{user?.Name}\" account is - {balance}";
    }

    private string GetNearAtms()
    {
        var sb = new StringBuilder("Near ATMs:\n\n");

        foreach (var atm in _atmService.GetAll())
        {
            sb.AppendLine($"[ID: {atm.Id}]: Street: {atm.Address}");
        }

        return sb.ToString();
    }

    private string GetOperationHistory()
    {
        var user = _authService.GetCurrentUser();

        var sb = new StringBuilder("Operations:\n\n");

        foreach (var transaction in user?.Transactions ?? [])
        {
            sb.AppendLine($"[{transaction.Time}]: {transaction.Ammount}");
        }

        return sb.ToString();
    }

    private void inputTextBox_Click(object sender, EventArgs e)
    {
        keyBoardPanel.Visible = true;
    }

    private void withdrawInputTextBox_Click(object sender, EventArgs e)
    {
        keyBoardPanel.Visible = true;
    }

    private void depositInputTextBox_Click(object sender, EventArgs e)
    {
        keyBoardPanel.Visible = true;
    }

    private void SendToCardInputTextBox_Click(object sender, EventArgs e)
    {
        keyBoardPanel.Visible = true;
    }


    private void goBackButton_Balance_Click(object sender, EventArgs e)
    {
        ShowMainMenuPage();
    }

    private void goBackButton_Deposit_Click(object sender, EventArgs e)
    {
        ShowBalancePage();
    }

    private void goBackButton_History_Click(object sender, EventArgs e)
    {
        ShowMainMenuPage();
    }

    private void goBackButton_MainMenu_Click(object sender, EventArgs e)
    {
        ShowLoginPage();
    }

    private void goBackButton_nearAtm_Click(object sender, EventArgs e)
    {
        ShowMainMenuPage();
    }

    private void goBackButton_SendToCard_Click(object sender, EventArgs e)
    {
        ShowBalancePage();
    }

    private void goBackButton_Withdraw_Click(object sender, EventArgs e)
    {
        ShowBalancePage();
    }

    private void showBalancePageButton_Click(object sender, EventArgs e)
    {
        ShowBalancePage();
    }

    private void showHistoryPageButton_Click(object sender, EventArgs e)
    {
        ShowOperationHistoryPage();
    }

    private void showNearAtmPageButton_Click(object sender, EventArgs e)
    {
        ShowNearAtmsPage();
    }

    private void depositButton_Click(object sender, EventArgs e)
    {
        ShowDepositPage();
    }

    private void withdrawButton_Click(object sender, EventArgs e)
    {
        ShowWithdrawPage();
    }

    private void sendToCardButton_Click(object sender, EventArgs e)
    {
        ShowSendToCardPanel();
    }
}