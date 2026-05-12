using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class NegativeNumbers
    {
        int[] arr = [1, 2, -3, 4, 5, 6, 7, -8];
        public void negativeNumbers()
        {
            Console.WriteLine("Negative numbers in the array:");
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
