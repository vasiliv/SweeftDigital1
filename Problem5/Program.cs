using System;

namespace Problem5
{
    class Program
    {         
        static void Main(string[] args)
        {
            Console.WriteLine(countVariants(5));
        }                
        public static int countVariants(int stearsCount)
        {
            int a = 1;
            int b = 2;
            int c = 0;
            for (int i = 2; i < stearsCount; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
