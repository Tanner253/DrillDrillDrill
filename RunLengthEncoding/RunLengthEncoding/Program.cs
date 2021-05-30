using System;
using System.Text;

namespace RunLengthEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "AAAAAABBBBBCCCCDDDEEFFPPPPLLLLSSSSRRRR";
            var res = RunLengthEncoding(input);
            Console.WriteLine(res) ;
        }

        public static string RunLengthEncoding(string str)
        {
            StringBuilder encodedStringChars = new StringBuilder();

            int runningLength = 1;
            for(int i = 1; i < str.Length; i++)
            {
                char currentChar = str[i];
                char previousChar = str[i - 1];

                if((currentChar != previousChar) || runningLength == 9)
                {
                    encodedStringChars.Append(runningLength.ToString());
                    encodedStringChars.Append(previousChar);
                    runningLength = 0;
                }
                runningLength += 1;
            }
            encodedStringChars.Append(runningLength.ToString());
            encodedStringChars.Append(str[str.Length - 1]);
            return encodedStringChars.ToString();
        }
    }
}
