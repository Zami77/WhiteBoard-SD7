using System;

namespace Quiz4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quiz4.Program.Main()");
            Console.WriteLine($"Question1: {Question1()}");
            Console.WriteLine($"Question2: {Question2()}");
            Console.WriteLine($"Question3: {Question3()}");
            Console.WriteLine($"Question4: {Question4()}");
            Console.WriteLine($"Question5: {Question5()}");
            Console.WriteLine($"Question6: {Question6()}");

        }
        public static int Question1()
        {
            int[] z = { -99, 0, 1, 2, 3, 5, 8, 13, 21, 34 };
            int x = int.MaxValue;
            foreach (var y in z) x = y < x ? y : x;

            return x;
        }
        public static int Question2()
        {
            string[] arr = { "the", "quick", "brown", "fox" };
            int x = arr[arr.Length - 1].Length;
            return x;
        }
        public static bool Question3()
        {
            bool x;
            int a = 6;
            int b = 3;
            a = ++a;
            b = b & 1;
            x = (a == b);
            return x;
        }
        public static string Question4()
        {
            string y = "mbilg";
            string x = "";
            for (int i = 0; i < y.Length; i++)
            {
                x += Convert.ToChar(y[i] - i);
            }
            return x;
        }
        public static int Question5()
        {
            int x, y = 93;
            x = y % 10;
            x *= 10;
            x += y / 10;
            return x;
        }
        public static string Question6()
        {
            int happy;
            var hi = true;
            string[] dwarf =
                {"0:>", ": {", "x)",":)","|<",":|",":/"};
            for (happy = 0; happy < dwarf.Length; happy++)
            {
                bool ho = !(hi);
                hi = ho;
            }
            var x = dwarf[happy / 2] == ":)" ? "hi!" : "ho!";
            return x;
        }
    }
}
