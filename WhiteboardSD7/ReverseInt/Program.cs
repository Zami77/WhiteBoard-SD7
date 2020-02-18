using System;

namespace ReverseInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12;
            ReverseInt(ref x,ref y);
            Console.WriteLine($"X:{x} Y:{y}");
        }

        static void ReverseInt(ref int x,ref int y)
        {
            y = x + y;
            x = y - x;
            y = y - x;

        }
    }
}
