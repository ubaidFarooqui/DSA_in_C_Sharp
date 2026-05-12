using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ExitsinArray
    {
        public void existinArray(int[] arr, int n) {

            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] == n) {
                    Console.WriteLine("Element " + n + " exists in the array at location " + (i + 1) + ".");
                    return;  // exit the method after finding the element
                }
            }
            Console.WriteLine("Element " + n + " does not exist in the array.");
        }
    }
}
