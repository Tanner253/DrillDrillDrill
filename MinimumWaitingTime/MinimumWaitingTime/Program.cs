using System;

namespace MinimumWaitingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int MinimumWaitingTime(int[] arr)
        {
            Array.Sort(arr);

            int time = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                int duration = arr[i];
                int queriesLeft = arr.Length - (i + 1);
                time += duration * queriesLeft;
            }
            return time;
        }
    }
}
