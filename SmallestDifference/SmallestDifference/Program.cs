using System;

namespace SmallestDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);
            int idxOne = 0;
            int idxTwo = 0;
            int smallest = Int32.MaxValue;
            int current = Int32.MaxValue;

            int[] smallestPair = new int[2];
            while (idxOne < arrayOne.Length && idxTwo < arrayTwo.Length)
            {
                int first = arrayOne[idxOne];
                int second = arrayTwo[idxTwo];
                if (first > second)
                {
                    smallest = second - first;
                    idxOne++;
                }
                else if (second < first)
                {
                    smallest = first - second;
                }
                else { return new int[] { first, second }; }
                if (smallest > current)
                {
                    smallest = current;
                    smallestPair = new int[] { first, second };
                }
            }
            return smallestPair;
        }
    }
}
