//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Yifan Xu">
//     No copyright lol
// </copyright>
//-----------------------------------------------------------------------
namespace Homework_6_8
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Main Class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry Point for the program
        /// </summary>
        /// <param name="args">Build arguments</param>
        public static void Main(string[] args)
        {
        }

        /// <summary>
        /// Parse a string to a double
        /// </summary>
        /// <param name="input">The string that is being parsed</param>
        /// <returns>The double parsed from the given string</returns>
        public static double StringToDouble(string input)
        {
            return double.Parse(input);
        }

        /// <summary>
        /// Parse a hex decimal in string into a standard 10-base integer
        /// </summary>
        /// <param name="hexInput">Hex decimal input string</param>
        /// <param name="output">The integer value of the hex decimal</param>
        /// <returns>Whether if the parser were able to parse the input string</returns>
        public static bool TryHexToInt(string hexInput, out int output)
        {
            output = 0;
            if (hexInput == null)
            {
                return false;
            }

            if (!hexInput.StartsWith("0x"))
            {
                return false;
            }

            hexInput = hexInput.Substring(2);

            Dictionary<char, int> hexDictionary = new Dictionary<char, int>()
            {
                { '0', 0 },
                { '1', 1 },
                { '2', 2 },
                { '3', 3 },
                { '4', 4 },
                { '5', 5 },
                { '6', 6 },
                { '7', 7 },
                { '8', 8 },
                { '9', 9 },
                { 'A', 10 },
                { 'B', 11 },
                { 'C', 12 },
                { 'D', 13 },
                { 'E', 14 },
                { 'F', 15 },
            };
            int factor = 1;
            for (int i = hexInput.Length - 1; i >= 0; i--)
            {
                if (!hexDictionary.TryGetValue(hexInput[i], out int digit))
                {
                    return false;
                }

                output += digit * factor;
                factor *= hexDictionary.Count;
            }

            return true;
        }

        /// <summary>
        /// Calculate an expression in the form of {number}{operation}{number}
        /// </summary>
        /// <param name="expression">The expression being calculated</param>
        /// <param name="result">Result of the expression</param>
        /// <returns>Whether if the expression could be read</returns>
        public static bool Calculate(string expression, out double result)
        {
            result = 0;
            if (string.IsNullOrEmpty(expression))
            {
                return false;
            }

            Dictionary<char, Func<double, double, double>> operations = new Dictionary<char, Func<double, double, double>>()
            {
                { '+', Add },
                { '-', Subtract },
                { '*', Multiply },
                { '/', Divide }
            };

            for (int i = 0; i < expression.Length; i++)
            {
                if (operations.TryGetValue(expression[i], out Func<double, double, double> function))
                {
                    if (TryParseHexOrDouble(expression.Substring(0, i), out double a) && TryParseHexOrDouble(expression.Substring(i + 1), out double b))
                    {
                        result = function(a, b);
                        return true;
                    }

                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Count how many words there are in a string
        /// </summary>
        /// <param name="s">the string</param>
        /// <returns>how many words are in the string</returns>
        public static int WordCount(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            return s.Split(' ').Length;
        }

        /// <summary>
        /// Count many times words appear in a string
        /// </summary>
        /// <param name="input">The string to be counted</param>
        /// <returns>A dictionary containing how many times each word appears</returns>
        public static Dictionary<string, int> WordAppearance(string input)
        {
            if (input == null)
            {
                return null;
            }

            input = input.ToLower();
            Dictionary<string, int> words = new Dictionary<string, int>();
            string[] splittedString = input.Split(' ');
            foreach (string s in splittedString)
            {
                if (string.IsNullOrEmpty(s))
                {
                    continue;
                }

                if (words.ContainsKey(s))
                {
                    words[s]++;
                }
                else
                {
                    words.Add(s, 1);
                }
            }

            return words;
        }

        /// <summary>
        /// Try to parse a given string into hex or double
        /// </summary>
        /// <param name="s">input string</param>
        /// <param name="output">The returned parsed double value</param>
        /// <returns>Whether if the parser were able to parse the string</returns>
        private static bool TryParseHexOrDouble(string s, out double output)
        {
            if (double.TryParse(s, out output))
            {
                return true;
            }

            if (TryHexToInt(s, out int num))
            {
                output = Convert.ToDouble(num);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Add a and b
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second Number</param>
        /// <returns>Sum of a and b</returns>
        private static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtract a from b
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second Number</param>
        /// <returns>Difference of a and b</returns>
        private static double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiply a and b
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second Number</param>
        /// <returns>Product of a and b</returns>
        private static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Divide a by b
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second Number</param>
        /// <returns>Quotient of a and b</returns>
        private static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
