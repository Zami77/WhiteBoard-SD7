using System;

namespace ReturnChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ReturnChar.Program.Main()");
            Console.WriteLine(ReturnCharIndex("Marge",'M'));
            Console.WriteLine(ReturnCharPosition("Marge", 'M'));

        }

        public static int ReturnCharIndex(string input, char checkChar)
        {
            int index = 0;
            while (index < input.Length)
            {
                if (input[index].Equals(checkChar)) return index;
                index++;
            }
            //If not found return -1
            return -1;
        }
        public static int ReturnCharPosition(string input, char checkChar)
        {
            int index = 0;
            while (index < input.Length)
            {
                if (input[index].Equals(checkChar)) return index + 1;
                index++;
            }
            //If not found return -1
            return -1;
        }
    }
}
