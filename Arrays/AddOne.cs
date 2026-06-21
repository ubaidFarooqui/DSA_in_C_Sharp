using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class AddOne
    {
        public List<int> addOne(int[] arr)
        {
            Console.WriteLine("The original array is: " + string.Join(", ", arr));
            List<int> ans = new List<int>();
            int n = arr.Length;
            int carry = 1;
            //return new List<int>();
            for (int i = n - 1; i >= 0; i--)
            {
                if (arr[i] + carry <= 9)
                {
                    ans.Add(arr[i] + carry);
                    carry = 0;
                }
                else { // arr[i] + carry = 10
                    ans.Add(0);
                    carry = 1;
                }
            }
            if (carry == 1) ans.Add(1);
            ans.Reverse();
            Console.WriteLine("The modified array is: " + string.Join(", ", ans));
            return ans;
        }
    }
}

/* Expected Output:
 
The original array is: 1, 2, 3, 4, 5, 6, 7, 8
The modified array is: 1, 2, 3, 4, 5, 6, 7, 9

*/
