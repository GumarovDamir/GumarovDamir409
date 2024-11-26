using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.ExtractDigit
{
    internal class ExtractDigit
    {
        static void Main(string[] args)
        {
            string input = "Сейчас 2024 год, 21 век";
            string result = ExtractDigits(input);
            Console.WriteLine(result);
        }
        static string ExtractDigits(string input)
        {
            string digits = string.Empty;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    digits += c;
                }
            }
            return digits;
        }
    }
}
