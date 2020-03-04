using System;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{CountWords("    This is how many     words this      has     ")}");
            Console.WriteLine($"{CountWordsDifferent("    This is how many     words this      has    ")}");

        }
        public static int CountWords(string input)
        {
            int count = 0;
            foreach(string s in input.Split(" "))
            {
                if(!string.IsNullOrEmpty(s))
                    count++;
            }
            return count;
        }

        public static int CountWordsDifferent(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == ' ')
                {
                    if (i < (input.Length - 2))
                    {
                        if (input[i + 1] == ' ' || ((i+1) == input.Length-1))
                            continue;
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
