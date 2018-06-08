using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{

    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int month = ParseInput(Console.ReadLine());
                if(month == -1)
                {
                    Console.WriteLine("Input is not a number");
                }
                else if(month == -2)
                {
                    Console.WriteLine("Number Out of Domain (1 <= x <= 12)");
                }
                Console.WriteLine(GetMonthByMagic(month));
            }
        }

        public static int GetMonthByArray(int month)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException("month", "Month Number must be between 1 and 12");
            }

            int[] months = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return months[month - 1];
        }

        public static int GetMonthByMagic(int month)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException("month", "Month Number must be between 1 and 12");
            }

            if (month == 2)
            {
                return 28;
            }
            if (month >= 8)
            {
                month--;
            }
            return 30 + month % 2;
        }

        public static int GetMonthBySwitch (int month)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException("month", "Month Number must be between 1 and 12");
            }

            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return 28;
                default:
                    return 31;
            }
        }

        /// <summary>
        /// Parse Input into months and detect any input errors
        /// </summary>
        /// <param name="input">User Input as a string</param>
        /// <returns>-1 if input not number, -2 if number is out of domain</returns>
        public static int ParseInput(string input)
        {
            input = input.Trim();
            int output = 0;
            if(!int.TryParse(input,out output))
            {
                return -1;
            }
            if(output < 1 || output > 12)
            {
                return -2;
            }
            return output;
        }
    }
}
