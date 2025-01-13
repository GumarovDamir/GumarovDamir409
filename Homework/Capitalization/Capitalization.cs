using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Capitalization
{
    internal class Capitalization
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            string result = CapitalizationOfTheText(input);
            Console.WriteLine(result);

        }
        static string CapitalizationOfTheText(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
            return string.Join(" ", words);
        }
    }
}
