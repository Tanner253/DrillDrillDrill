using System;

namespace NonConstructibleChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = new int[] { 5, 7, 1, 1, 2, 3, 22 };
            var result = NonConstructibleChange(coins);
            Console.WriteLine(result);
        }
        public static int NonConstructibleChange(int[] coins)
        {
            //this is done in place, ask in interview if this should be the case.
            //sorting causes runtime to be O(nlogn)
            Array.Sort(coins);
            int currentChangeCreated = 0;

            foreach(var coin in coins)
            {
                if(coin > currentChangeCreated + 1)
                {
                    return currentChangeCreated + 1;
                }
                currentChangeCreated += coin;
            }
            return currentChangeCreated + 1;
        }
    }
}
