using System;

namespace FindLettersInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(alphaString("ZhAnG"));
        }

        public static string alphaString(string input)
        {
            string result = "";
            input = input.ToLower();
            for (int i = 'a'; i <= 'z'; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == i)
                    {
                        result += input[j];
                        break;
                    }
                }
                

            }

            return result;
        }
    }
}
