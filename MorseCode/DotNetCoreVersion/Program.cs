using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreVersion
{
    class Program
    {
        static readonly Dictionary<char, string> EnglishToMorse = new Dictionary<char, string>()
        {
            {' ' , " " },
            {'A' , ".-"},
            {'B' , "-..."},
            {'C' , "-.-."},
            {'D' , "-.."},
            {'E' , "."},
            {'F' , "..-."},
            {'G' , "--."},
            {'H' , "...."},
            {'I' , ".."},
            {'J' , ".---"},
            {'K' , "-.-"},
            {'L' , ".-.."},
            {'M' , "--"},
            {'N' , "-."},
            {'O' , "---"},
            {'P' , ".--."},
            {'Q' , "--.-"},
            {'R' , ".-."},
            {'S' , "..."},
            {'T' , "-"},
            {'U' , "..-"},
            {'V' , "...-"},
            {'W' , ".--"},
            {'X' , "-..-"},
            {'Y' , "-.--"},
            {'Z' , "--.."},
            {'0' , "-----"},
            {'1' , ".----"},
            {'2' , "..---"},
            {'3' , "...--"},
            {'4' , "....-"},
            {'5' , "....."},
            {'6' , "-...."},
            {'7' , "--..."},
            {'8' , "---.."},
            {'9' , "----."},
            {'.' , ".-.-.-" },
            {',' , "--..--" },
            {'?' , "..--.." },
            {'\'', ".----." },
            {'!' , "-.-.--" },
            {'/' , "-..-." },
            {'(' , "-.--." },
            {')' , "-.--.-" },
            {':' , "---..." },
            {';' , "-.-.-." },
            {'=' , "-...-" },
            {'+' , ".-.-." },
            {'-' , "-....-" },
            {'_' , "..--.-" },
            {'"' , ".-..-." },
            {'$' , "...-..-"},
            {'@' , ".--.-." }
        };
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Current supporting {0} characters", EnglishToMorse.Count);
            while (true)
            {
                input = Console.ReadLine();
                try
                {
                    Console.WriteLine(TranslateEnglishToMorse(input));
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} occured: {1}", e.GetType(), e.Message);
                }
            }

        }

        public static string TranslateEnglishToMorse(string input)
        {
            input = input.ToUpper();
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                string output;
                if (!EnglishToMorse.TryGetValue(input[i], out output))
                {
                    throw new ArgumentException($"Given text is not supported by Morse Code. Invalid Text: \"{input[i]}\" ({i + 1}th character) ");
                }
                s.Append(output);
                s.Append("   ");
            }

            return s.ToString().Trim();
        }
    }
}
