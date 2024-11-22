using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDigit
{
    internal class ThreeDigitNaturNumbers
    {
        class Sample3
        {
            static void Main(string[] args)
            {
                Console.Write("Введите число в диапазоне от 1 до 27: ");
                int a = int.Parse(Console.ReadLine());
                if (a < 1 || a > 27)
                {
                    Console.WriteLine("Не в диапазоне");
                }
                int result = 0;
                for (int i = 1; i <= 9; i++)
                {
                    for (int o = 0; o <= 9; o++)
                    {
                        for (int p = 0; p <= 9; p++)
                        {
                            if (i + o + p == a)
                            {
                                result++;
                            }
                        }
                    }
                }
                Console.WriteLine($"Количество трехзначных натуральных чисел, сумма цифр которых равна {a}: {result}");
            }
        }
    }
}
