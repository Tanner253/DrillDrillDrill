using System;
using System.Linq;
using System.Collections.Generic;
namespace FirstNonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "ABCDAF";
            Console.WriteLine(FirstNonRepeatingCharacter(input));
        }
        public static int FirstNonRepeatingCharacter(string str)
        {
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();
            foreach(char letter in str)
            {
                charFrequency[letter] = charFrequency.GetValueOrDefault(letter, 0) + 1;
            }
            for(int i = 0; i < str.Length; i++)
            {
                if(charFrequency[str[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
