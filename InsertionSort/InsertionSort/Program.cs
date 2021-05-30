using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 8, 5, 2, 9, 5, 6, 3 };
            var res = InsertionSort(arr);
            foreach(var num in res)
            {
                Console.WriteLine($"{num}");
            }
        }
        public static int[] InsertionSort(int[] array)
        {
            if(array.Length == 0 ){ return new int[] { }; }
            
            for(var i = 1; i < array.Length; i++)
            {
                int j = i;
                while(j > 0 && array[j] < array[j - 1])
                {
                    Swap(j, j - 1, array);
                    j -= 1;
                }
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
