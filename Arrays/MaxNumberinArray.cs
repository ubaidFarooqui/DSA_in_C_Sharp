using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class MaxNumberinArray
    {
        public void maxNumberArray() { 
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max = arr[0]; // assuming the first element is the maximum

            for (int i = 0;  i< arr.Length; i++)
            {
                if (arr[i] > max) { 
                    max = arr[i]; // update max if current element is greater
                }
            }
            for (int j = 0; j < arr.Length; j++) {
               
                Console.Write(arr[j] + ", ");
            }
            Console.WriteLine(); // for a new line after printing the array
            Console.WriteLine("The maximum number in the array is: " + max);
        }
    }
}

/* Expected Output
 1, 2, 3, 4, 5, 6, 7, 8, 9,
The maximum number in the array is: 9
 */
