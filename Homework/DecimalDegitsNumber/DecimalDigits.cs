using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalDigitsNumber
{
    internal class DecimalDigits
    {
        static void Main(string[] args)
        {
            Console.Write("Введите положительной число: ");
            int a = int.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Отрицательное число");
            }
            int result = 0;
            while (a > 0)
            {
                result = result * 10;
                int b = a % 10;
                result += b;
                a /= 10;
            }
            Console.WriteLine($"Число в обратном порядке: {result}");
        }
    }
}
