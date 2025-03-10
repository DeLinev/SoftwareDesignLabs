namespace Singleton
{
    public sealed class Authenticator
    {
        private static Authenticator? instance;
        private static object _refObj = new object();

        private Authenticator() 
        {
            Console.WriteLine("Creating an instance of a class...");
            Thread.Sleep(500);
        }

        public static Authenticator GetInstance()
        {
            if (instance == null)
            {
                lock (_refObj)
                {
                    if (instance == null)
                    {
                        instance = new Authenticator();
                    }
                }
            }

            return instance;
        }
    }
}
