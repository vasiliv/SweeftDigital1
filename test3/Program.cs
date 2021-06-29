using System;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(10));
        }
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps, compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
