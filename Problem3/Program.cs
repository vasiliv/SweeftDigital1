using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {6, 3, 2, 1 };
            int number = NotContains(array);
            Console.WriteLine("Number = " + number);
            Console.ReadKey();
        }
        static int NotContains(int[] array)
        {
            int number = 1;
            for (int i = 0; i < array.Length; i++) {
                if (array[i] > 0) {
                    if (array[i] == number)
                    {
                        number++;
                        i = -1;
                    }
                }
            }
            return number;
        }
    }
}
