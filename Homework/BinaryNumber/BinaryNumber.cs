using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.BinaryNumber
{
    internal class BinaryNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Введите положительное число а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Число отрицательно");
            }
            if (a > 0)
            {
                string bin = "";
                int number = a;
                while (number > 0)
                {
                    int remainder = number % 2;
                    bin = remainder.ToString() + bin;
                    number /= 2;
                }
                Console.WriteLine($"Двоичное представление числа: {bin} ");
            }
        }
    }
}
