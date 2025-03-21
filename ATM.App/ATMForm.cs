using ATM.DesktopApp.Interfaces;
using ATM.DesktopApp.Pages;
using ATM.DesktopApp.Utils;
using ATM.Logic;
using ATM.Logic.Interfaces;
using ATM.Logic.Models;
using ATM.Logic.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Xml.Linq;

namespace ATM.DesktopApp;

public partial class ATMForm : Form
{
    public delegate void ShowPageDelegate(string pageName, bool useKeyboard = false);

    private readonly IServiceProvider _serviceProvider;
    private Dictionary<string, IWinFormsPage> _pages;
    private IWinFormsPage _currentPage;
    private Panel _currentVisiblePanel;

    public ATMForm(IServiceProvider serviceProvider)
    {
        InitializeComponent();

        _serviceProvider = serviceProvider;

        InitializePages();
        ShowPage("Login", true);
    }

    private void InitializePages() 
    {
        _pages = new Dictionary<string, IWinFormsPage>()
        {
            { "Login", new LoginPage(loginPanel, _serviceProvider.GetRequiredService<IAuthService>(), ShowPage) },
            { "MainMenu", new MainMenuPage(mainMenuPanel, _serviceProvider.GetRequiredService<IAuthService>(), ShowPage) },
            { "Balance", new BalancePage(balancePanel, _serviceProvider.GetRequiredService<IAuthService>(), _serviceProvider.GetRequiredService<IBankService>(), ShowPage) },
            { "Deposit", new DepositPage(depositPanel,  _serviceProvider.GetRequiredService<IAuthService>(), _serviceProvider.GetRequiredService<IBankService>(), ShowPage) },
            { "Withdraw", new WithdrawPage(withdrawPanel,  _serviceProvider.GetRequiredService<IAuthService>(), _serviceProvider.GetRequiredService<IBankService>(), ShowPage) },
            { "SendToCard", new SendToCardPage(sendToCardPanel, _serviceProvider.GetRequiredService<IAuthService>(), _serviceProvider.GetRequiredService<IBankService>(), ShowPage) },
            { "OperationHistory", new OperationHistoryPage(historyPanel, _serviceProvider.GetRequiredService<IAuthService>(), ShowPage) },
            { "NearAtms", new NearAtmsPage(nearAtmsPanel, _serviceProvider.GetRequiredService<IAtmService>(), ShowPage) },
        };
    }

    private void HideAllPages()
    {
        loginPanel.Visible = false;
        mainMenuPanel.Visible = false;
        balancePanel.Visible = false;
        withdrawPanel.Visible = false;
        depositPanel.Visible = false;
        sendToCardPanel.Visible = false;
        historyPanel.Visible = false;
        nearAtmsPanel.Visible = false;
        keyBoardPanel.Visible = false;
    }

    private void ShowPage(string pageName, bool useKeyboard = false)
    {
        HideAllPages();

        if (_currentPage != null)
        {
            _currentPage.PagePanel.Visible = false;
        }

        if (_pages.ContainsKey(pageName))
        {
            _currentPage = _pages[pageName];
            _currentPage.PagePanel.Visible = true;
            _currentVisiblePanel = _currentPage.PagePanel;

            if (useKeyboard)
            {
                keyBoardPanel.Visible = true;
            }

            _currentPage.InitializePage();
        }
        else
        {
            MessageBox.Show($"Page {pageName} doesn't found!");
            ShowPage("Login", true);
        }
    }

    private void buttonDigit1_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = RenderHelper.FindControlOnPanelByTag<TextBox>("inputTextBox", _currentPage.PagePanel);

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '1';
        }
    }

    private void buttonDigit2_Click(object sender, EventArgs e)
    {

        TextBox currentInputTextBox = RenderHelper.FindControlOnPanelByTag<TextBox>("inputTextBox", _currentPage.PagePanel);

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '2';
        }
    }

    private void buttonDigit3_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = RenderHelper.FindControlOnPanelByTag<TextBox>("inputTextBox", _currentPage.PagePanel);

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '3';
        }
    }

    private void buttonDigit4_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = RenderHelper.FindControlOnPanelByTag<TextBox>("inputTextBox", _currentPage.PagePanel);

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '4';
        }
    }

    private void buttonDigit5_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = RenderHelper.FindControlOnPanelByTag<TextBox>("inputTextBox", _currentPage.PagePanel);

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '5';
        }
    }

    private void buttonDigit6_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = RenderHelper.FindControlOnPanelByTag<TextBox>("inputTextBox", _currentPage.PagePanel);

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '6';
        }
    }

    private void buttonDigit7_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = RenderHelper.FindControlOnPanelByTag<TextBox>("inputTextBox", _currentPage.PagePanel);

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '7';
        }
    }

    private void buttonDigit8_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = RenderHelper.FindControlOnPanelByTag<TextBox>("inputTextBox", _currentPage.PagePanel);

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '8';
        }
    }

    private void buttonDigit9_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = RenderHelper.FindControlOnPanelByTag<TextBox>("inputTextBox", _currentPage.PagePanel);

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '9';
        }
    }

    private void buttonDigit0_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = RenderHelper.FindControlOnPanelByTag<TextBox>("inputTextBox", _currentPage.PagePanel);

        if (currentInputTextBox != null)
        {
            currentInputTextBox.Text += '0';
        }
    }

    private void buttonBackspace_Click(object sender, EventArgs e)
    {
        TextBox currentInputTextBox = RenderHelper.FindControlOnPanelByTag<TextBox>("inputTextBox", _currentPage.PagePanel);

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
        if (_currentPage != null)
        {
            Dictionary<string, Action> actions = _currentPage.GetActions();
            string actionName = _currentPage.CurrentActionName;

            if (actions.ContainsKey(actionName))
            {
                actions[actionName].Invoke();
            }
            else
            {
                MessageBox.Show($"Action {actionName} doesn't found for this page!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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
        if (_currentPage != null && _currentPage.GetActions().ContainsKey("GoBack"))
        {
            _currentPage.GetActions()["GoBack"].Invoke();
        }
    }

    private void goBackButton_Deposit_Click(object sender, EventArgs e)
    {
        if (_currentPage != null && _currentPage.GetActions().ContainsKey("GoBack"))
        {
            _currentPage.GetActions()["GoBack"].Invoke();
        }
    }

    private void goBackButton_History_Click(object sender, EventArgs e)
    {
        if (_currentPage != null && _currentPage.GetActions().ContainsKey("GoBack"))
        {
            _currentPage.GetActions()["GoBack"].Invoke();
        }
    }

    private void goBackButton_MainMenu_Click(object sender, EventArgs e)
    {
        if (_currentPage != null && _currentPage.GetActions().ContainsKey("GoBack"))
        {
            _currentPage.GetActions()["GoBack"].Invoke();
        }
    }

    private void goBackButton_nearAtm_Click(object sender, EventArgs e)
    {
        if (_currentPage != null && _currentPage.GetActions().ContainsKey("GoBack"))
        {
            _currentPage.GetActions()["GoBack"].Invoke();
        }
    }

    private void goBackButton_SendToCard_Click(object sender, EventArgs e)
    {
        if (_currentPage != null && _currentPage.GetActions().ContainsKey("GoBack"))
        {
            _currentPage.GetActions()["GoBack"].Invoke();
        }
    }

    private void goBackButton_Withdraw_Click(object sender, EventArgs e)
    {
        if (_currentPage != null && _currentPage.GetActions().ContainsKey("GoBack"))
        {
            _currentPage.GetActions()["GoBack"].Invoke();
        }
    }

    private void showBalancePageButton_Click(object sender, EventArgs e)
    {
        if (_currentPage != null && _currentPage.GetActions().ContainsKey("Balance"))
        { 
            _currentPage.GetActions()["Balance"].Invoke();
        }
    }

    private void showHistoryPageButton_Click(object sender, EventArgs e)
    {
        if (_currentPage != null && _currentPage.GetActions().ContainsKey("OperationHistory"))
        { 
            _currentPage.GetActions()["OperationHistory"].Invoke();
        }
    }

    private void showNearAtmPageButton_Click(object sender, EventArgs e)
    {
        if (_currentPage != null && _currentPage.GetActions().ContainsKey("NearAtms"))
        { 
            _currentPage.GetActions()["NearAtms"].Invoke();
        }
    }

    private void depositButton_Click(object sender, EventArgs e)
    {
        if (_currentPage != null && _currentPage.GetActions().ContainsKey("Deposit"))
        { 
            _currentPage.GetActions()["Deposit"].Invoke();
        }
    }

    private void withdrawButton_Click(object sender, EventArgs e)
    {
        if (_currentPage != null && _currentPage.GetActions().ContainsKey("Withdraw"))
        { 
            _currentPage.GetActions()["Withdraw"].Invoke();
        }
    }

    private void sendToCardButton_Click(object sender, EventArgs e)
    {
        if (_currentPage != null && _currentPage.GetActions().ContainsKey("SendToCard"))
        { 
            _currentPage.GetActions()["SendToCard"].Invoke();
        }
    }
}