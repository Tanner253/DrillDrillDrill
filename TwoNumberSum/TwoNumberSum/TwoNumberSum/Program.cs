using System;
using System.Collections.Generic;

namespace TwoNumberSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] {3, 5, -4, 8, 11, 1, -1, 6};
            int target = 10;
            var result = SumTwoNums(testArray, target);
            foreach(var item in result)
            {
                Console.WriteLine($"{item}");
            }
            Console.ReadKey();
        }
            public static int[] SumTwoNums(int[] testArray, int target)
            {
            HashSet<int> nums = new HashSet<int>();
            foreach(var item in testArray)
                {
                    int potentialMatch = target - item;
                    if (nums.Contains(potentialMatch)){
                        return new int[] { potentialMatch, item };
                    }
                    nums.Add(item);
                }
                return new int[0];
            }
       
        
    }
}
