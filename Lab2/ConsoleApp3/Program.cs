using Singleton;

class Program
{
    static void Main()
    {
        var threads = new Thread[5];

        for (int i = 0; i < threads.Length; i++)
        {
            int taskId = i;
            threads[i] = new Thread(() =>
                {
                    Console.WriteLine($"Thread {taskId} starting...");
                    Authenticator auth = Authenticator.GetInstance();
                    Console.WriteLine($"Thread {taskId} got authenticator instance");
                }
            );

            threads[i].Start();
        }

        foreach (var thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine("Trying to get instance twice in main thread...");
        Authenticator auth1 = Authenticator.GetInstance();
        Authenticator auth2 = Authenticator.GetInstance();

        Console.WriteLine($"Are both references the same instance? {ReferenceEquals(auth1, auth2)}");
    }
}