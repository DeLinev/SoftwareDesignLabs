using Composite;

class Program
{
    static void Main()
    {
        var table = new LightElementNode("table");
        table.AddCssClass("products-table", "dashed-border", "striped");

        var thead = new LightElementNode("thead");
        thead.AddChild(GetHeaderRow("ID", "Product Name"));

        var tbody = new LightElementNode("tbody");

        for (int i = 1; i <= 10; i++)
        {
            tbody.AddChild(GetProductRow(i, "Product " + i));
        }

        table.AddChild(thead);
        table.AddChild(tbody);

        Console.WriteLine(table.OuterHtml());

        Console.WriteLine("Total child elements: " + table.ChildElementsCount());
        Console.WriteLine("Total direct children of the element: " + table.Children.Count);

        var img = new LightElementNode("img", true, true);
        img.AddCssClass("product-image");

        Console.WriteLine("====================================");
        Console.WriteLine(img.OuterHtml());
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