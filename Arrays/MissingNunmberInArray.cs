using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class MissingNunmberInArray
    {
        public void missingNumberInAray(int[] arr) { 

            int n = arr.Length + 1; // Since one number is missing, the total count should be length + 1
            int sum = n * (n + 1) / 2; // Sum of first n natural numbers
            int arraySum = 0;
            for (int i = 0; i < arr.Length; i++) { 
            arraySum += arr[i]; // Calculate the sum of the elements in the array
            }
            int missingNumber = sum - arraySum; // The missing number is the difference between expected and actual sum
            Console.WriteLine("The array is: " + string.Join(", ", arr));
            Console.WriteLine("The missing number in the array is: " + missingNumber);
        }
    }
}

/* Expected Output:

The array is: 1, 2, 3, 4, 5, 6, 8
The missing number in the array is: 7

*/
