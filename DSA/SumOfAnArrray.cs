using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class SumOfAnArrray
    {
        public void sumOfAnArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int sum = 0;
            foreach(int num in arr) {
                sum = sum + num;
            }
            Console.WriteLine("Sum of an array is: " + sum);
        }
    }
}
