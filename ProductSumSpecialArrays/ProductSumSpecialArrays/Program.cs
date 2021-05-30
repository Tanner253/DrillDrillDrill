using System;
using System.Collections.Generic;

namespace ProductSumSpecialArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<object> array = new List<object>();
            array.Add(5);
            array.Add(2);
            array.Add(new List<object> { 7, -2 });
            array.Add(3);
            array.Add(new List<object> { 6, new List<object> { -13, 8 }, 4 }) ;
            var result = ProductSumHelper(array, 1);
            Console.WriteLine($"{result}");


        }
        public static int ProductSumHelper(List<object> array, int multiplier)
        {
            int sum = 0;
            foreach(object el in array)
            {
                if(el is IList<object>)
                {
                    sum += ProductSumHelper((List<object>)el, multiplier + 1);
                }
                sum += (int)el;
            }
            return sum * multiplier;
        }
    }
}
