using System;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MySingleton mySingleton = MySingleton.Instance;
            mySingleton.DoSomething();
        }
    }

    public class MySingleton
    {
        private static MySingleton instance = null;
        public static MySingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MySingleton();
                }
                return instance;
            }
        }

        private MySingleton()
        {

        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton class code has been called");
        }
    }
}
