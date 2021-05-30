using System;

namespace FindThreeLargestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7 };
            var res = FindThreeLargest(arr);
            foreach(var item in res)
            {

            Console.WriteLine($"${item}");
            }
        }
        public static int[] FindThreeLargest (int[] array)
        {
            int[] threeLargest = new int[] { Int32.MinValue, Int32.MinValue, Int32.MinValue };
            foreach(var num in array)
            {
                UpdateLargest(threeLargest, num);
            }
            return threeLargest;
        }

        public static void UpdateLargest(int[] threeLargest, int num)
        {
            if(num > threeLargest[2])
            {
                UpdateAndShift(threeLargest, num, 2);
            }else if(num > threeLargest[1])
            {
                UpdateAndShift(threeLargest, num, 1);
            }else if(num > threeLargest[0])
            {
                UpdateAndShift(threeLargest, num, 0);
            }
        }
        
        public static void UpdateAndShift(int[] array, int num, int idx)
        {
            for(var i = 0; i <= idx; i++)
            {
                if(i == idx)
                {
                    array[i] = num;
                }
                else
                {
                    array[i] = array[i + 1];
                }
            }
        }
    }
}
