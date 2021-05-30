using System;
using System.Collections.Generic;

namespace GenerateDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static bool GenerateDocument(string characters, string document)
        {
            HashSet<char> alreadyCounted = new HashSet<char>();

            for(int i = 0; i < document.Length; i++)
            {
                char character = document[i];
                if (alreadyCounted.Contains(character))
                {
                    continue;
                }
                int documentFrequency = GetCharFrequency(character, document);
                int charactersFrequency = GetCharFrequency(character, characters);

                if(documentFrequency > charactersFrequency)
                {
                    return false;
                }
            }
            return true;
        }
        public static int GetCharFrequency(char character, string target)
        {
            int frequency = 0;
            for(int i = 0; i < target.Length; i++)
            {
                char c = target[i];
                if( c == character)
                {
                    frequency += 1;
                }
            }
            return frequency;
        }
    }
}
