using System;

namespace GetNthFib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int GetNthFib(int n)
        {
            if(n == 2)
            {
                return 1;
            }
            if(n == 1)
            {
                return 0;
            }
            return GetNthFib(n - 1) + GetNthFib(n - 2);
        }
    }
}
