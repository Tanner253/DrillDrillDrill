using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 8, 5, 2, 9, 5, 6, 3 };
            var res = SelectionSort(array);
            foreach(var item in res)
            {
                Console.WriteLine($"{item}");
            }
        }
        public static int[] SelectionSort(int[] array)
        {
            if(array.Length == 0) { return new int[] { }; }
            int startIdx = 0;
            while(startIdx < array.Length - 1)
            {
                int smallestIdx = startIdx;
                for(int i = startIdx + 1; i < array.Length; i++)
                {
                    if(array[i] < array[smallestIdx])
                    {
                        smallestIdx = i;
                    }
                }
                Swap(startIdx, smallestIdx, array);
                startIdx++;
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
