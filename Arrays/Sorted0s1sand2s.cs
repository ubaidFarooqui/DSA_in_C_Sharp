using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Sorted0s1sand2s
    {
        public void sort0s1sand2s(int[] arr)
        {
            Console.WriteLine("Original Array: " + string.Join(", ", arr));
            int zeroCount = 0;
            int oneCount = 0;
            int twoCount = 0;

            // Count occurrences
            foreach (int num in arr)
            {
                if (num == 0)
                    zeroCount++;
                else if (num == 1)
                    oneCount++;
                else if (num == 2)
                    twoCount++;
            }

            // Create new sorted array
            int[] sorted = new int[arr.Length];
            int index = 0;

            for (int i = 0; i < zeroCount; i++)
                sorted[index++] = 0;

            for (int i = 0; i < oneCount; i++)
                sorted[index++] = 1;

            for (int i = 0; i < twoCount; i++)
                sorted[index++] = 2;

            Console.WriteLine("Sorted Array: " + string.Join(", ", sorted));
        }
    }
}