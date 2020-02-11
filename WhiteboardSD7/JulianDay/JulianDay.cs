using System;

namespace JulianDay
{
    public class JulianDay
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JulianDays.Program.Main()");
            Console.WriteLine($"January 1st:{GetJulian(1,1)} day(s)");
            Console.WriteLine($"March 5th:{GetJulian(5, 3)} day(s)");

        }

        public static int GetJulian(int day, int month)
        {
            //TODO: test for valid months
            int julianDays = 0;
            for (int i = 1; i < month; i++)
            {
                switch (i)
                {
                    case 1:
                        julianDays += 31;
                        break;
                    case 2:
                        julianDays += 28;
                        break;
                    case 3:
                        julianDays += 31;
                        break;
                    case 4:
                        julianDays += 30;
                        break;
                    case 5:
                        julianDays += 31;
                        break;
                    case 6:
                        julianDays += 30;
                        break;
                    case 7:
                        julianDays += 31;
                        break;
                    case 8:
                        julianDays += 31;
                        break;
                    case 9:
                        julianDays += 30;
                        break;
                    case 10:
                        julianDays += 31;
                        break;
                    case 11:
                        julianDays += 30;
                        break;
                    case 12:
                        julianDays += 31;
                        break;
                    default:
                        break;
                }
               
            }
            julianDays += day;
            return julianDays;
        }
        enum months
        {
            January = 31, February = 28, March = 31, April = 30, May = 31, 
            June = 30, July = 31, August = 31, September = 30, October = 31, 
            November = 30, December = 31
        }


    }
}
