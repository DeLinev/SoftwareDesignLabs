using Proxy;

class Program
{
    static void Main()
    {
        IReader reader = new SmartTextReader();
        IReader checker = new SmartTextChecker(reader);
        IReader locker = new SmartTextReaderLocker(reader, @"restricted_.*\.txt");
        IReader lockerChecker = new SmartTextReaderLocker(checker, @"restricted_.*\.txt");

        Console.WriteLine("Using SmartTextReader to read file.txt:");
        char[][] text = reader.ReadFile(@"..\..\..\Files\file.txt");
        reader.DisplayByLetters(text);

        Console.WriteLine("\nUsing SmartTextChecker to read file.txt:");
        text = checker.ReadFile(@"..\..\..\Files\file.txt");
        checker.DisplayByLetters(text);

        Console.WriteLine("\nUsing SmartTextReaderLocker to read restricted_file.txt:");
        text = locker.ReadFile(@"..\..\..\Files\restricted_file.txt");
        locker.DisplayByLetters(text);

        Console.WriteLine("\nUsing SmartTextReaderLocker to read file.txt:");
        text = locker.ReadFile(@"..\..\..\Files\file.txt");
        locker.DisplayByLetters(text);

        Console.WriteLine("\nUsing locker and checker to read restricted_file.txt:");
        text = lockerChecker.ReadFile(@"..\..\..\Files\restricted_file.txt");
        lockerChecker.DisplayByLetters(text);

        Console.WriteLine("\nUsing locker and checker to read file.txt:");
        text = lockerChecker.ReadFile(@"..\..\..\Files\file.txt");
        lockerChecker.DisplayByLetters(text);
    }
}