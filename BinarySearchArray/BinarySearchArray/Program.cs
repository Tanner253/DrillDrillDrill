using System;

namespace BinarySearchArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 };
            int requesting = 33;
            var res = BinarySearch(arr, requesting, 0, arr.Length - 1);
            Console.WriteLine($"{res}");
        }
        public static int BinarySearch(int[] arr, int target, int left, int right)
        {
            if (left > right) { return -1; }
            int middle = (left + right) / 2;
            int potentialMatch = arr[middle];
            if(target == potentialMatch)
            {
                return middle;
            }else if(target < potentialMatch)
            {
                return BinarySearch(arr, target, left, middle - 1);
            }else if(potentialMatch < target)
            {
                return BinarySearch(arr, target, middle + 1, right);
            }
            return -1;
        }
    }
}
