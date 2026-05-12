using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Segregate0and1
    {
        public void segregate0and1(int[] arr) {
            //for 0s
            Console.WriteLine("The original array is: " + string.Join(", ", arr));
            int count = 0;
            foreach(int x in arr)
            {
                if (x == 0) {
                    count++;
                }
            }
            //fill in the array with 0s until count
            for (int i = 0; i < count; i++) {
                arr[i] = 0;
            }
            //fillin the array with 1s until the end of the array
            for (int i = count; i < arr.Length; i++) {
                arr[i] = 1;
            }
            
            Console.WriteLine("The segregated array is: " + string.Join(", ", arr));
        }
    }
}
