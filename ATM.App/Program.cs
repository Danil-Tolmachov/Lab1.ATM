using ATM.Logic;
using ATM.Logic.Interfaces;
using ATM.Logic.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ATM.DesktopApp;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        Application.ThreadException += Application_ThreadException;
        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandleException;

        var builder = new ServiceCollection();

        builder.AddSingleton<MockDatabase>();
        builder.AddSingleton<IAuthService, AuthService>();
        builder.AddSingleton<IBankService, BankService>();
        builder.AddScoped<IAtmService, AtmService>();

        var services = builder.BuildServiceProvider();

        Application.Run(new ATMForm(services));
    }

    private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
        MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private static void CurrentDomain_UnhandleException(object sender, UnhandledExceptionEventArgs e)
    {
        Exception exception = (Exception)e.ExceptionObject;

        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
