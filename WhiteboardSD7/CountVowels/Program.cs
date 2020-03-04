using System;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CountVowel.Program.Main()");
            Console.WriteLine(CountVowels("Dogs are cool"));
        }

        public static int CountVowels(string input)
        {
            input.ToLower();
            int vowelCount = 0;
            if (string.IsNullOrEmpty(input))
                return 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                        vowelCount++;
                        break;
                    case 'e':
                        vowelCount++;
                        break;
                    case 'i':
                        vowelCount++;
                        break;
                    case 'o':
                        vowelCount++;
                        break;
                    case 'u':
                        vowelCount++;
                        break;
                    case 'y':
                        vowelCount++;
                        break;
                    default:
                        break;
                }
            }
            return vowelCount;
        }
    }
}
