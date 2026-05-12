using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ProductofanArray
    {
        public void productofanArray()
        {
            int[] arr = { 1, 2, 3, 4};

            int prod = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                prod *= arr[i];
            }
            Console.WriteLine("Product of the array is: " + prod);

        }
    }
}

/* Expected Ouput
 
Product of the array is: 24

 */

