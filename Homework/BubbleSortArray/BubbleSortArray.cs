using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.NewFolder1
{
    internal class BubbleSortArray
    {
        static int[] BubbleSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }

            return arr;
        }


        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 6, 2, 7, 3, 5 };
            int[] sorted = BubbleSort(arr);
            foreach (var value in sorted)
            {
                Console.WriteLine(value);
            }
        }
    }
}
