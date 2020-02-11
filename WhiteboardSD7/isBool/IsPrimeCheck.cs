using System;

namespace IsPrimeCheckSpace
{
    public class IsPrimeCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IsPrime.Program.Main()");
            //Console.WriteLine(IsPrime(2));
            //Console.WriteLine(IsPrime(3));
            //Console.WriteLine(IsPrime(5));
            //Console.WriteLine(IsPrime(7));
            //Console.WriteLine(IsPrime(11));
            //Console.WriteLine(IsPrime(13));
            //Console.WriteLine(IsPrime(125));
            Console.WriteLine(AddPrimes(5));
        }
        public static bool IsPrime(int num)
        {
            if (num < 2)
                return false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public static int AddPrimes(int numPrimes)
        {
            int primeCount = 0;
            int counter = 2;
            int result = 0;
            while ( primeCount < numPrimes)
            {
                if (IsPrime(counter))
                {
                    result += counter;
                    primeCount++;
                }
                counter++;
            }
            return result;
        }
    }
}
