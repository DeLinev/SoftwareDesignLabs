using Composite;
using Composite.Visitor;

class Program
{
    static void Main()
    {
        var table = new LightElementNode("table");
        table.AddCssClass("products-table", "dashed-border", "striped");

        var thead = new LightElementNode("thead");
        thead.AddChild(GetHeaderRow("ID", "Product Name"));

        var tbody = new LightElementNode("tbody");

        for (int i = 1; i <= 5; i++)
        {
            tbody.AddChild(GetProductRow(i, "Product " + i));
        }

        table.AddChild(thead);
        table.AddChild(tbody);

        Console.WriteLine(table.OuterHtml());

        var countVisitor = new CountVisitor();
        table.Accept(countVisitor);
        var searchVisitor = new SearchVisitor("th", "Prod", "header");
        table.Accept(searchVisitor);

        Console.WriteLine("Text node count: " + countVisitor.TextNodeCount);
        Console.WriteLine("Element node count: " + countVisitor.ElementNodeCount);
        Console.WriteLine("Total child elements: " + countVisitor.NodesCount);
        foreach (var tag in countVisitor.TagCount)
        {
            Console.WriteLine($"Tag: {tag.Key}, Count: {tag.Value}");
        }
        Console.WriteLine("====================================");
        Console.WriteLine("Search results:");
        Console.WriteLine("- Element Matches:");
        foreach (var element in searchVisitor.ElementMatches)
        {
            Console.WriteLine(element.OuterHtml());
        }
        Console.WriteLine("- Text Matches:");
        foreach (var text in searchVisitor.TextMatches)
        {
            Console.WriteLine(text.OuterHtml());
        }
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
            th.AddCssClass("header");
            row.AddChild(th);
        }
        return row;
    }
}