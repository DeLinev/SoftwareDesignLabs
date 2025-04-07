using Flyweight;

class Program
{
    static void Main()
    {
        Console.WriteLine("Converting to LightHTML without flyweight:");

        long memoryBefore = GC.GetTotalMemory(true);
        var standardDoc = new LightHtmlDocument();
        standardDoc.LinesToHtml(File.ReadAllLines(@"..\..\..\text.txt"));
        long memoryAfter = GC.GetTotalMemory(true);
        long usedMemoryWithoutFW = memoryAfter - memoryBefore;

        Console.WriteLine($"Used Memory: {usedMemoryWithoutFW} bytes");

        Console.WriteLine("\nConverting to LightHTML with flyweight:");

        memoryBefore = GC.GetTotalMemory(true);
        var flyweightDoc = new LightHtmlDocument();
        flyweightDoc.LinesToHtmlWithFlyweight(File.ReadAllLines(@"..\..\..\text.txt"));
        memoryAfter = GC.GetTotalMemory(true);
        long usedMemoryWithFW = memoryAfter - memoryBefore;

        Console.WriteLine($"Used Memory: {usedMemoryWithFW} bytes");
        Console.WriteLine($"\nMemory saved: {usedMemoryWithoutFW - usedMemoryWithFW} bytes");

        string standardHtml = standardDoc.GetHTML();
        string flyweightHtml = flyweightDoc.GetHTML();

        Console.WriteLine($"\nDoes HTML look the same in both methods? {standardHtml == flyweightHtml}");
    }
}
