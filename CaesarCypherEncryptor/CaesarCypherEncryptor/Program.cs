using System;

namespace CaesarCypherEncryptor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //this problem is an exercise that is great for understaninding modulus
        }

        public static string CaesarCypherEncryptor(string str, int key)
        {
            char[] newLetters = new char[str.Length];
            //allows us to remove duplicate passes, as each 26 go by we are doing 1 loop effectivly duplicating work.
            int newKey = key % 26;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            for(int i = 0; i < str.Length; i++)
            {
                newLetters[i] = GetNewLetter(str[i], key, alphabet);
            }
            return new string(newLetters);
        }
        public static char GetNewLetter(char letter, int key, string alphabet)
        {
            int newLetterCode = alphabet.IndexOf(letter) + key;
            return alphabet[newLetterCode % 26];
        }
    }
}
