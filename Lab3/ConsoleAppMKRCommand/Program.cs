using Composite;
using Composite.Command;
using Composite.Command.Commands;
using System.Text;

class Program
{
    static void Main()
    {
        var table = new LightElementNode("table");
        table.AddCssClass("products-table", "dashed-border", "striped");

        var thead = new LightElementNode("thead");
        thead.AddChild(GetHeaderRow("ID", "Product Name"));

        var tbody = new LightElementNode("tbody");
        table.AddChild(thead);
        table.AddChild(tbody);

        var invoker = new CommandInvoker();
        int productId = 1;

        StringBuilder textBuffer = new StringBuilder();
        ConsoleKeyInfo keyInfo;

        Console.WriteLine(table.OuterHtml());
        Console.WriteLine("Press V to add a new product row.");
        Console.WriteLine("Press A to make the last added product active.");
        Console.WriteLine("Press Ctrl+Z to undo the last action.");
        Console.WriteLine("Press Esc to exit.");

        while (true)
        {
            keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Escape)
                break;

            if (keyInfo.Key == ConsoleKey.V)
            {
                var newRow = GetProductRow(productId, "Product " + productId);
                var addRowCommand = new AddChildCommand(tbody, newRow);
                invoker.ExecuteCommand(addRowCommand);
                productId++;
                UpdateConsole(table.OuterHtml());
            }
            else if (keyInfo.Key == ConsoleKey.A)
            {
                if (tbody.Children.Count > 0)
                {
                    var lastRow = tbody.Children[^1] as LightElementNode;
                    if (lastRow != null)
                    {
                        var makeActiveCommand = new MakeActiveCommand(lastRow, "active");
                        invoker.ExecuteCommand(makeActiveCommand);
                        UpdateConsole(table.OuterHtml());
                    }
                }
            }
            else if (keyInfo.Key == ConsoleKey.Z && keyInfo.Modifiers.HasFlag(ConsoleModifiers.Control))
            {
                invoker.Undo();
                UpdateConsole(table.OuterHtml());
            }
        }
    }

    static void UpdateConsole(string text)
    {
        Console.Clear();
        Console.WriteLine(text);
        Console.WriteLine("Press V to add a new product row.");
        Console.WriteLine("Press A to make the last added product active.");
        Console.WriteLine("Press Ctrl+Z to undo the last action.");
        Console.WriteLine("Press Esc to exit.");
    }

    static LightElementNode GetProductRow(int id, string product)
    {
        LightElementNode row = new LightElementNode("tr");

        LightElementNode td1 = new LightElementNode("td");
        td1.AddChild(new LightTextNode(id.ToString()));
        LightElementNode td2 = new LightElementNode("td");
        td2.AddChild(new LightTextNode(product));

        row.AddChild(td1);
        row.AddChild(td2);
        return row;
    }

    static LightElementNode GetHeaderRow(params string[] columnNames)
    {
        LightElementNode row = new LightElementNode("tr");
        foreach (var columnName in columnNames)
        {
            LightElementNode th = new LightElementNode("th");
            th.AddChild(new LightTextNode(columnName));
            row.AddChild(th);
        }
        return row;
    }
}
