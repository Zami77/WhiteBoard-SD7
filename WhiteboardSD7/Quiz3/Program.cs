using System;

namespace Quiz3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quiz3.Program.Main()");
            Console.WriteLine($"Question1:{Question1()}");
            Console.WriteLine($"Question2:{Question2()}");
            Console.WriteLine($"Question3:{Question3()}");
            Console.WriteLine($"Question4:{Question4()}");
            Console.WriteLine($"Question5:{Question5()}");
            Console.WriteLine($"Question6:{Question6()}");

        }
        public static int Question1()
        {
            int x = 0b01100011;
            return x;
        }
        public static int Question2()
        {
            int x = 1;

            do
            {
                x += 10;
            } while (false);

            return x;
        }
        public static int Question3()
        {
            int i;
            for (i = 0; i < 10; i++)
            {

            }
            int x = i;
            return x;
        }
        public static int Question4()
        {
            int y = 4;
            int x = 2;

            do
            {
                x += y;
            } while (y-- > 1);

            return x;
        }
        public static int Question5()
        {
            int x;
            int value1 = 1;
            do
            {
                var Value1 = 'A';
                //System.Console.WriteLine(Value1++);
            } while (value1-- > 0);

            x = value1;
            return x;
        }
        public static int Question6()
        {
            int x, y = 55;
            x = y % 10;
            x *= 10;
            x += y / 10;
            return x;
        }
    }
}
