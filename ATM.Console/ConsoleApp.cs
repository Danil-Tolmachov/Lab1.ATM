using ATM.ConsoleApp.Interfaces;
using ATM.ConsoleApp.Pages;
using ATM.ConsoleApp.Utils;

namespace ATM.ConsoleApp;

public class ConsoleApp : IConsoleApp
{
    private Stack<IPage> PagesHistory { get; set; } = new Stack<IPage>();

    public ConsoleApp(IServiceProvider serviceProvider)
    {
        PagesHistory.Push(new LoginPage(serviceProvider));
    }

    public void Run()
    {
        var cts = new CancellationTokenSource();
        var checkForResizeThread = CheckForResizeThread(cts.Token);

        // Start thread checking for console resize.
        checkForResizeThread.Start();

        while (true)
        {
            // Exit application if there is no current page.
            if (!PagesHistory.TryPeek(out IPage? pageToDisplay))
            {
                cts.Cancel();
                cts.Dispose();
                Environment.Exit(0);
                return;
            }

            // Render page.
            var applicationHeader = GetHeader();
            RenderHelper.DisplayPage(pageToDisplay, applicationHeader);

            // Select action.
            var key = Console.ReadKey(intercept: true);

            // Go Back if escape is pressed.
            if (key.Key == ConsoleKey.Escape)
            {
                PagesHistory.Pop();
                continue;
            }

            var selectedAction = pageToDisplay.GetActions()
                                              .FirstOrDefault(a => a.Key == key.Key);

            // Check if selected key is not mapped to action.
            if (selectedAction.Equals(default(KeyValuePair<ConsoleKey, ApplicationAction>)))
            {
                RenderHelper.DisplayInvalidAction();
                continue;
            }

            // Act.
            ExecuteAction(selectedAction.Value);
        }
    }

    private void ExecuteAction(ApplicationAction action)
    {
        try
        {
            action.Action();

            if (action.NextPage is not null)
            {
                PagesHistory.Push(action.NextPage);
            }
        }
        catch
        {
            RenderHelper.DisplayInvalidAction();
        }
    }

    private static string GetHeader()
    {
        var frameChar = '#';
        var message = " ATM Console Application ";

        return RenderHelper.GetHeaderMessage(message, frameChar);
    }

    private Thread CheckForResizeThread(CancellationToken cancellationToken)
    {
        return new Thread(() =>
        {
            var currentWidth = Console.WindowWidth;
            var currentHeight = Console.WindowHeight;

            while (!cancellationToken.IsCancellationRequested)
            {
                // If console size is changed.
                if (currentHeight != Console.WindowHeight
                    || currentWidth != Console.WindowWidth)
                {
                    // Update current dimensions.
                    currentWidth = Console.WindowWidth;
                    currentHeight = Console.WindowHeight;

                    // Rerender page.
                    if (PagesHistory.TryPeek(out IPage? pageToDisplay))
                    {
                        RenderHelper.DisplayPage(pageToDisplay, GetHeader());
                    }
                }

                Thread.Sleep(300);
            }
        });
    }
}
