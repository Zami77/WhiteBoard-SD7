using System;

namespace EnumPractice
{
    class Program
    {
        enum month
        {
            jan = 1, feb, mar,apr, may, jun, jul, aug, sep, oct, nov, dec
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"jan: {(int) month.jan}");
            string[] monthNames =
            {
                "jan", "feb", "mar","apr","may", "jun", "jul" ,"aug", "sep","oct","nov","dec"
            };
        }
    }
}
