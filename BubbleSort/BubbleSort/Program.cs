using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 8, 5, 2, 9, 5, 6, 3 };
            var res = BubbleSort(array);
            foreach(var item in res)
            {
                Console.WriteLine($"{item}");
            }
        }
        public static int[] BubbleSort(int[] array)
        {
            if(array.Length == 0) { return new int[] { }; }
            bool isSorted = false;
            int counter = 0;
            while (!isSorted)
            {
                isSorted = true;
                for(var i = 0; i < array.Length - 1; i++)
                {
                    if(array[i] > array[i + 1])
                    {
                        Swap(i, i + 1, array);
                        isSorted = false;
                    }
                }
                counter++;
            }
            return array;
        }
        public static void Swap(int i, int j, int[] array)
        {
            int temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
}
