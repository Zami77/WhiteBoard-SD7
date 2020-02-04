using System;

namespace StringReversal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringReversal.Program.Main()");
            Console.WriteLine(Reversal("I Like Dogs"));
        }

        public static string Reversal(string input)
        {
            string reverse = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }
            return reverse;
        }
    }
}
