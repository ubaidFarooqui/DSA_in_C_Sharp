using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class RotateArray
    {
        public void rotateArray(int[] arr, int d) { 
            int n = arr.Length;
            d = d % n; // Handle cases where d is greater than n
            reverseArray(arr, 0, d - 1);  // d is the number of elements to be rotated
            reverseArray(arr, d, n - 1); // from d to the end of the array
            reverseArray(arr, 0, n - 1); // reverse the entire array
        }

        public void reverseArray(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;           
            }
        }
    }
}

/* Expected Ouput: 
Original array: 1, 2, -3, 0, 9
Rotated array: -3, 0, 9, 1, 2
 */
