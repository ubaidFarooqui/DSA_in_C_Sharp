using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class SeconMaxNumberInArray
    {
        public void secondMaxNumberinArray(int[] arr) {
            int max = arr[0];
            int smax = arr[0];

            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > max) { 
                 max = arr[i]; 
                }
            }
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > smax && arr[i] != max) {
                    smax = arr[i];
                }
            }
            Console.WriteLine("The maximum number in the array is: " + max);
            Console.WriteLine("The second maximum number in the array is: " + smax);
        }
    }
}
