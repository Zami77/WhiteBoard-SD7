using System;

namespace Forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCount = 3;
            Console.WriteLine("SumOfOdds.Program.Main()");
            Console.WriteLine($"SumOfOdds({nCount}):{SumOfOdds(nCount)}");
        }

        public static int SumOfOdds(int nCount)
        {
            int sum = 0;
            int nextOddNumber = 1;
            for (int i = 0; i < nCount; i++)
            {
                sum += nextOddNumber;
                nextOddNumber += 2;
            }
            return sum;
        }
    }
}
