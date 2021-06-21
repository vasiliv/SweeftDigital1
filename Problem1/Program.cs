using System;

namespace Problem1
{
    class Program
    {
        public static bool answer;
        static void Main(string[] args)
        {
            bool result = isPalindrome("abra");
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static bool isPalindrome(String text)
        {

            for (int i = 0; i < (int)text.Length / 2; i++)
            {
                if (text[i] == text[text.Length - 1 - i])
                {
                    answer = true;
                }
                else
                {
                    return false;
                }
            }
            return answer;
        }
    }
}
