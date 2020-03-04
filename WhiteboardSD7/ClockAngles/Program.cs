using System;

namespace ClockAngles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ClockAngles.Program.Main()");
            Console.WriteLine($"{AngleBetweenHands(12, 45)}");
        }

        public static double AngleBetweenHands(int hour, int minutes)
        {
            if ((hour > 12) || (hour < 0) || (minutes > 60) || (minutes < 0))
                return -1.0;
            double hourAngle = (double) hour / 12.0 * 360.0;
            double minAngle = (double) minutes / 60.0 * 360.0;
            return Math.Abs(minAngle - hourAngle);
        }
    }
}
