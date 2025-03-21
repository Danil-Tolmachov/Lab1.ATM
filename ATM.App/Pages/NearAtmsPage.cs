using ATM.DesktopApp.Interfaces;
using ATM.DesktopApp.Utils;
using ATM.Logic.Interfaces;
using System.Text;

namespace ATM.DesktopApp.Pages;

public class NearAtmsPage : IWinFormsPage
{
    private Panel _pagePanel;
    private readonly IAtmService _atmService;
    private readonly ATMForm.ShowPageDelegate _showPage;
    private Label nearAtmsLabel;
    private Label nearAtmsInfoLabel;

    public Panel PagePanel => _pagePanel;
    public string CurrentActionName { get; set; }

    public NearAtmsPage(Panel pagePanel, IAtmService authService, ATMForm.ShowPageDelegate showPage)
    {
        _pagePanel = pagePanel;
        _atmService = authService;
        _showPage = showPage;
    }

    public void InitializePage()
    {
        nearAtmsInfoLabel = RenderHelper.FindControlOnPanel<Label>("nearAtmInfoLabel", _pagePanel);
        nearAtmsLabel = RenderHelper.FindControlOnPanel<Label>("nearAtmLabel", _pagePanel);
        if (nearAtmsInfoLabel != null && nearAtmsLabel != null)
        {
            nearAtmsLabel.Text = "Near ATM's";
            nearAtmsInfoLabel.Text = GetNearAtms();
        }
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
