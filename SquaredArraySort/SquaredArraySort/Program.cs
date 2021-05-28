using System;

namespace SquaredArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, -10 };
            int[] collection = SortedSquaredArray(array);
            foreach(var item in collection)
            {
                Console.WriteLine(item);
            }
            
                }
        public static int[] SortedSquaredArray(int[] array)
        {
            int[] output = new int[array.Length];
            for(var i = 0; i < array.Length; i++)
            {
                output[i] = array[i] * array[i];
            }
            Array.Sort(output);
            return output;
        }
    }
}
