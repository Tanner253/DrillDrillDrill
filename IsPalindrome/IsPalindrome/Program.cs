using System;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string testTrue = "abababa";
            string testFalse = "abababac";
            Console.WriteLine(IsPalindrome(testTrue));
            Console.WriteLine(IsPalindrome(testFalse));
        }

        public static bool IsPalindrome(string str)
        {
            string isReversed = "";
            for (var i = str.Length - 1; i >= 0; i--)
            {
                isReversed += str[i];
            }
            return str.Equals(isReversed);
        }
    }
}
