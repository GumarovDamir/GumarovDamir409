using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.ReversedArray
{
    internal class ReversedArray
    {
       static int[] ReverseArray(int[] arr)
        {
            int j = arr.Length - 1;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int t = arr[i];
                arr[i] = arr[j];
                arr[j] = t;
                j--;
            }

            return arr;
        }


        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4 };
            var reversedArray = ReverseArray(values);
            foreach (int value in reversedArray)
            {
                Console.WriteLine(value);
            }
        }
    }
}
