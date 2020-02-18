using System;
using System.Collections.Generic;

namespace DistinctElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DistinctElements.Program.Main()");
            int[] arr = { 1, -1, 3, 4,4,5 };
            Console.WriteLine($"{DistinctElements(arr)}");
            Console.WriteLine($"{DistinctElementsAnswer(arr)}");

        }

        public static int DistinctElements(int[] arrInput)
        {
            int numOfDist = 0, curDistCount = 0, counter = 0;
            List<int> numsAdded = new List<int>();
            //int[] numsChecked = new int[arrInput.Length];
            //for (int i = 0; i < numsChecked.Length; i++)
            //{
            //    numsChecked[i] = -1;
            //}
            
            for (int i = 0; i < arrInput.Length; i++)
            {
                for (int j = 0; j < arrInput.Length; j++)
                {
                    if(arrInput[i] == arrInput[j])
                    {
                        curDistCount++;
                        //if(!isInArray(arrInput[i],numsChecked))
                        //{
                        //    numsChecked[counter++] = arrInput[i];
                        //}
                        if (!numsAdded.Contains(arrInput[i]))
                        {
                            numsAdded.Add(arrInput[i]);
                        }
                    }
                }
                if(curDistCount == 1)
                {
                    numOfDist++;
                }
                curDistCount = 0;
            }
            //numOfDist = 0;
            //for (int i = 0; i < numsChecked.Length; i++)
            //{
            //    if (numsChecked[i] >= 0)
            //        numOfDist++;
            //}
            //return numOfDist;
            return numsAdded.Count;
        }
        public static bool isInArray(int numToCheck, int[]array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == numToCheck)
                    return true;
            }
            return false;
        }

        public static int DistinctElementsAnswer(int[] intArray)
        {
            int count = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                bool isNew = true;
                for (int j = 0; j < i; j++)
                {
                    if (intArray[i] == intArray[j])
                        isNew = false;
                }
                if (isNew) count++;
            }
            return count;
        }


    }
}
