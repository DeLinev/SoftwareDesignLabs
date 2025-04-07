using Adapter;

class Program
{
    static void Main()
    {
        string logFilePath = @"..\..\..\logFile.txt";

        Console.WriteLine("Console Logger:");
        ILogger consoleLogger = new Logger();
        consoleLogger.Log("Some informaiton to log.");
        consoleLogger.Warn("Important warning!");
        consoleLogger.Error("Oops... Something went wrong!");

        Console.WriteLine("\nFile Logger:");

        FileWriter fileWriter = new FileWriter(logFilePath);
        ILogger fileLogger = new FileLogger(fileWriter);

        fileLogger.Log("Some informaiton to log.");
        fileLogger.Warn("Important warning!");
        fileLogger.Error("Oops... Something went wrong!");

        Console.WriteLine($"Logs were written to a file: {Path.GetFullPath(logFilePath)}");

        if (File.Exists(logFilePath))
        {
            Console.WriteLine("\nContents of the log file:");
            Console.WriteLine(File.ReadAllText(logFilePath));
        }
    }
}