using System;
using System.Collections.Generic;

namespace ThreeNumerSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
            int targetSum = 0;
            var result = ThreeNumberSum(input, targetSum);
            foreach(var item in result)
            {
                foreach(var output in item)
                {
                Console.WriteLine($"{output}");
                }

            }
        }
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            Array.Sort(array);
            int currentSum = 0;
            List<int[]> triplets = new List<int[]>();
            for(int i = 0; i < array.Length; i++)
            {
                int left = i + 1;
                int right = array.Length - 1;

                while( left < right)
                {
                currentSum = array[i] + array[left] + array[right];
                    if(currentSum == targetSum)
                    {
                        int[] triplet = new int[] { array[i], array[left], array[right] };
                        triplets.Add(triplet);
                        left++;
                        right--;
                    }else if(currentSum > targetSum) { right--; }
                    else if(currentSum < targetSum) { left++; }
                }
            }
            return triplets;
        }
    }
}
