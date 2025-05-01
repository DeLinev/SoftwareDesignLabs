using Composite;
using Composite.State;
using System;

class Program
{
    static void Main()
    {
        var checkbox = new LightElementNode("checkbox", isBlock: false, isSelfClosing: true);

        Console.WriteLine(checkbox.OuterHtml());
        Console.WriteLine("Press 'c' to click the checkbox, 'd' to disable it, or 'q' to quit.");

        while (true)
        {
            var key = Console.ReadKey(intercept: true).Key;

            if (key == ConsoleKey.C)
            {
                checkbox.Click();
                UpdateConsole(checkbox.OuterHtml());
            }
            else if (key == ConsoleKey.D)
            {
                checkbox.SetState(new DisabledState(checkbox));
                UpdateConsole(checkbox.OuterHtml());
            }
            else if (key == ConsoleKey.Q)
            {
                Console.WriteLine("Exiting program.");
                break;
            }
        }
    }

    static void UpdateConsole(string text)
    {
        Console.Clear();
        Console.WriteLine(text);
        Console.WriteLine("Press 'c' to click the checkbox, 'd' to disable it, or 'q' to quit.");
    }
}