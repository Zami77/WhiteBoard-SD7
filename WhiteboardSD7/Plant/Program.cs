using System;

namespace Plant
{
    public class Plant
    {
        public int numberOfLeaes;
        public string flowerColor;
        public int averageHeightInFeet;
        public int height;


        public int Grow(double growthRate)
        {
            this.height++;
            return (int) (this.height * (1 + growthRate));
        }
    }
    public class Pineapple : Plant
    {
        public Pineapple()
        {
            this.averageHeightInFeet = 1;
            this.height = 1;
        }
    }
    public class PineTree : Plant
    {
        public PineTree()
        {
            this.averageHeightInFeet = 4;
            this.height = 4;
        }
    }
    public class Program
    {
        public static void BuildNursery()
        {
            PineTree[] trees = new PineTree[10];
            Pineapple[] shrubs = new Pineapple[4];
            for (int i = 0; i < trees.Length; i++)
            {
                trees[i] = new PineTree();
                double rate = 1;
                if((i%3) == 1)
                {
                    rate = 2;
                }
                trees[i].height = trees[i].Grow(rate);
                Console.WriteLine($"Tree {i} is {trees[i].height} feet tall");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Plant.Program.Main()");
            BuildNursery();
        }
    }
}
