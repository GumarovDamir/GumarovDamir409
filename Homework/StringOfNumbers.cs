using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class StringOfNumbers
    {
            static void Main(string[] args)
            {
                string text = "Сегодня 2024 год";
                string result = ExtractDigits(text);
                Console.WriteLine(result);
            }
            static string ExtractDigits(string text)
            {
                return new string(text.Where(char.IsDigit).ToArray());
            }
        }
}
