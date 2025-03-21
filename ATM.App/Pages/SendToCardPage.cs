using ATM.DesktopApp.Interfaces;
using ATM.DesktopApp.Utils;
using ATM.Logic.Interfaces;
using ATM.Logic.Models;
using System;
using System.Data;

namespace ATM.DesktopApp.Pages;
public class SendToCardPage : IWinFormsPage
{
    private Panel _pagePanel;
    private readonly IAuthService _authService;
    private readonly IBankService _bankService;
    private readonly ATMForm.ShowPageDelegate _showPage;
    private TextBox sendToCardTextBox;
    private Label sendToCardLabel;
    private string cardNumber;

    public Panel PagePanel => _pagePanel;
    public string CurrentActionName { get; set; }

    public SendToCardPage(Panel pagePanel, IAuthService authService, IBankService bankService, ATMForm.ShowPageDelegate showPage)
    {
        _pagePanel = pagePanel;
        _authService = authService;
        _bankService = bankService;
        _showPage = showPage;
    }

    public void InitializePage()
    {
        CurrentActionName = "InputAmount";
        sendToCardTextBox = RenderHelper.FindControlOnPanel<TextBox>("sendToCardTextBox", _pagePanel);
        sendToCardLabel = RenderHelper.FindControlOnPanel<Label>("sendToCardLabel", _pagePanel);

        if (sendToCardTextBox != null)
        {
            sendToCardLabel.Text = "Enter Card Number";
            sendToCardTextBox.Text = string.Empty;
        }
    }

    public Dictionary<string, Action> GetActions()
    {
        return new Dictionary<string, Action>()
        {
            { "InputAmount", PerformInputAmount },
            { "SendToCard", PerformSendToCard },
            { "GoBack", PerformGoBack }
        };
    }

    private void PerformInputAmount()
    {
        if (sendToCardTextBox != null) 
        {
            cardNumber = sendToCardTextBox.Text;
            sendToCardTextBox.Text = string.Empty;
            if (sendToCardLabel != null) 
            {
                sendToCardLabel.Text = "Enter Amount";
            }
            CurrentActionName = "SendToCard";
        }
    }

    private void PerformSendToCard()
    {
        Account user = null;
        decimal result = 0;

        try
        {
            user = _authService.GetCurrentUser();
            if (user == null)
            {
                MessageBox.Show("User is not authorized", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _showPage("Login", true);
                return;
            }

            if (!decimal.TryParse(sendToCardTextBox.Text, out result)
                && string.IsNullOrEmpty(cardNumber))
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _showPage("SendToCard", true);
                return;
            }

            _bankService.SendToAccount(user.Id, cardNumber ?? string.Empty, result);
            _showPage("Balance");
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _showPage("SendToCard", true);
        }
        catch (InvalidOperationException ex)
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

    private void PerformGoBack()
    {
        _showPage("Balance");
    }
}
