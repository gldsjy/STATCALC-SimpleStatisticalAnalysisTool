using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATCALC_SimpleStatisticalAnalysisTool
{
    internal class Validation
    {
        public static int GetValidNumber(string msg)
        {
            int result = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Write(msg);
                string input = Console.ReadLine();

                if (IsAllDigits(input))
                {
                    result = Convert.ToInt32(input);

                    if (result > 0)
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a positive number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            return result;
        }

        public static double GetValidDouble(string msg)
        {
            double result = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Write(msg);
                string input = Console.ReadLine();
                if (input != null && input != "" && Convert.ToDouble(input) > 0)
                {
                    result = Convert.ToDouble(input);
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }

            return result;
        }

        public static bool YesOrNo(string prompt)
        {
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Write(prompt);
                string input = Console.ReadLine().ToLower();

                if (input == "y" || input == "n")
                {
                    isValidInput = true;
                    return input == "y";
                }
                else
                {
                    Console.WriteLine("Invalid input. Please press 'y' for Yes or 'n' for No.");
                }
            }

            return false;
        }

        private static bool IsAllDigits(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return !string.IsNullOrEmpty(input);
        }
    }
}
