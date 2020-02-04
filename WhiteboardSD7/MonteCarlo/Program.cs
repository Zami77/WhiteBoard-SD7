using System;
using System.Diagnostics;

namespace MonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MonteCarlo.Program.Main()");
            Random rand = new Random();
            (double x, double y) = randValues(rand);
            Console.WriteLine($"X:{x} Y:{y}");
            EstimatePi();

        }

        public static (double, double) randValues(Random r)
        {

            double x = r.NextDouble();
            double y = r.NextDouble();
            return (x, y);

        }
        public static void EstimatePi()
        {
            Random r = new Random();
            int exponent = 1;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //Loop to solve Pi for 10 seconds
            while(stopwatch.Elapsed < TimeSpan.FromSeconds(10))
            {
                int iterations;
                int countInCircle = 0;
                exponent++;
                for (iterations = 1; iterations < Math.Pow(10,exponent); iterations++)
                {
                    double x = r.NextDouble();
                    double y = r.NextDouble();
                    double z = Radius(x, y);
                    if (z <= 1.0) countInCircle++;

                }
                Console.WriteLine((double) 4.0 * (double)countInCircle / (double)iterations);

            }
        }

        public static double Radius(double x, double y) => Math.Sqrt(x * x + y * y);
    }
}
