using System;

namespace FlattenArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FlattenArray.Program.Main()");
            int[] arrToPrint = FlattenArray();
            for (int i = 0; i < arrToPrint.Length; i++)
            {
                Console.Write($"{arrToPrint[i]} ");
            }
        }

        public static int[] FlattenArray()
        {
            int[,] x =
            {
                {5,8,1 },
                {4,8,2 },
                {3,3,3 }
            };
            
            int currentIndex = 0;
            int[] y = new int[x.Length];
            for (int i = 0; i < x.GetLength(0); i++)
            {

                for (int j = 0; j < x.GetLength(1); j++)
                {
                    y[currentIndex++] = x[i,j];
                }

            }
            return y;
        }
    }
}
