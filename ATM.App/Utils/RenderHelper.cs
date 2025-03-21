using ATM.DesktopApp.Interfaces;

namespace ATM.DesktopApp.Utils;

public static class RenderHelper
{
    public static T FindControlOnPanel<T>(string controlName, Panel panel) where T : Control
    {
        return panel?.Controls.OfType<T>().FirstOrDefault(c => (string)c.Name == controlName);
    }
    
    public static T FindControlOnPanelByTag<T>(string controlName, Panel panel) where T : Control
    {
        return panel?.Controls.OfType<T>().FirstOrDefault(c => (string)c.Tag == controlName);
    }
}