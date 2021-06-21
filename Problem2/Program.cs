using System;
using System.Collections.Generic;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Amount: ");
            string inputText = (Console.ReadLine());

            while (!CheckInput(inputText))
            {
                Console.WriteLine("Enter Amount: ");
                inputText = (Console.ReadLine());
            }
            int amount = Convert.ToInt32(inputText);

            Console.WriteLine("Number = " + MinSplit(amount));
        }
        static int MinSplit(int amount)
        {
            int[] array = new int[] { 50, 20, 10, 5, 1 };
            int count = 0;

            List<int> list = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                while (amount >= array[i])
                {
                    amount = amount - array[i];
                    count++;

                    list.Add(array[i]);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            return count;
        }
        static bool CheckInput(string value)
        {
            int amount;
            bool checkResult = Int32.TryParse(value, out amount);
            return checkResult;
        }
    }
}
