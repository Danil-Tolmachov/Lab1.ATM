using ATM.ConsoleApp.Interfaces;

namespace ATM.ConsoleApp.Utils;

public static class RenderHelper
{
    public static string GetHeaderMessage(string message, char frameChar)
    {
        var consoleSize = Console.WindowWidth;

        var leftCount = (consoleSize - message.Length) / 2;

        var remainder = (consoleSize - message.Length) % 2;
        var rightCount = ((consoleSize - message.Length) / 2) + remainder;

        var leftFrame = string.Concat(Enumerable.Repeat(frameChar, leftCount));
        var rigthFrame = string.Concat(Enumerable.Repeat(frameChar, rightCount));

        return leftFrame + message + rigthFrame;
    }

    public static void DisplayPage(IPage page, string applicationHeader)
    {
        var actions = page.GetActions();
        var pageHeader = page.GetHeader();

        Console.Clear();

        // Display app header.
        Console.WriteLine(applicationHeader);
        Console.WriteLine();

        // Display page header.
        Console.WriteLine(pageHeader);
        Console.WriteLine();

        foreach (var action in actions)
        {
            var key = action.Key;
            var description = action.Value.Description;

            // Display action description.
            Console.WriteLine($" [{key}] - {description}");
        }

        Console.WriteLine();
        Console.WriteLine("Press Escape to go back.");
    }

    public static void DisplayInvalidAction()
    {
        // Print application header into console.
        Console.Clear();
        Console.WriteLine("Invalid Action!!!");

        Thread.Sleep(2000);
        Console.Clear();
    }
}
