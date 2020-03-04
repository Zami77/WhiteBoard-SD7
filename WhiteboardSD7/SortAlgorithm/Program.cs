using System;

namespace SortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SortAlgorithim.Program.Main()");
            int[] arrayToSort = SortArray(new int[] { 5, 3, 4, 1, 2 ,-17,56,2,0,43,55,-23});
            foreach(int num in arrayToSort)
            {
                Console.Write($"{num} ");
            }
        }

        //Ascending Order
        public static int[] SortArray(int[] input)
        {

            bool sorted = false, swapped = false;
            while(!sorted)
            {
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if(input[i] > input[i+1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    sorted = true;
                swapped = false;
            }
            return input;
        }
    }
}
