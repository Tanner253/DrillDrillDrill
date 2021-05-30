using System;

namespace TandemBicycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] blue = new int[] { 3, 6, 7, 2, 1 };
            int[] red = new int[] { 5, 5, 3, 9, 2 };

            Console.WriteLine(TandemBicycle(blue, red, true));
        }
        public static int TandemBicycle(int[] redShirtSpeeds, int[] blueShirtSpeeds, bool fastest)
        {
            Array.Sort(redShirtSpeeds);
            Array.Sort(blueShirtSpeeds);

            if (!fastest)
            {
                Array.Reverse(redShirtSpeeds);
            }
            int totalSpeed = 0;
            for(var i = 0; i < redShirtSpeeds.Length; i++)
            {
                int rider1 = redShirtSpeeds[i];
                int rider2 = blueShirtSpeeds[blueShirtSpeeds.Length - i - 1];
                totalSpeed += Math.Max(rider1, rider2);
            }
            return totalSpeed;
        }
        /*
         * public void ReverseArrayInPlace(int[] array){
         * int start = 0;
         * int end = array.Length - 1;
         * while(start < end){
         *  int temp = array[start];
         *  array[start] = array[end]
         *  array[end] = temp;
         *  start += 1;
         *  end += 1;
         * }
         * return reveresed array 
         * }
         */
    }
}
