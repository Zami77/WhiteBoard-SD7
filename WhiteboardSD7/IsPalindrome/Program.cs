using System;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IsPalindrome.Program.Main()");
            Console.WriteLine(IsPalindrome("dog"));
        }

        public static bool IsPalindrome(string input)
        {
            input = input.ToLower();
            int palinIndex = input.Length - 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[palinIndex--]) return false;
            }
            return true;
        }
    }
}
