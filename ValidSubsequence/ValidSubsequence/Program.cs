using System;
using System.Collections.Generic;

namespace ValidSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            List<int> subsequence = new List<int> { 1, 6, -1, 10 };

            bool result = IsValidSubsequence(array, subsequence);
            Console.WriteLine(result.ToString());
        }

        public static bool IsValidSubsequence(List<int> array, List<int> subsequence)
        {
            int pointer = 0;
            foreach(var num in array)
            {
                if(pointer == subsequence.Count)
                {
                    break;
                }
                if(num == subsequence[pointer])
                {
                    pointer++;
                }

            }
                return pointer == subsequence.Count;
            
        }
    }
}
