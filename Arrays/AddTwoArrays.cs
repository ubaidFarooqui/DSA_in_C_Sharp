using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class AddTwoArrays
    {
        public void addTwoArrays(int[] arr1, int[] arr2) {
            int i = arr1.Length - 1;
            int j= arr2.Length - 1;
            int carry = 0;
            List<int> ans = new List<int>();

            while (i >= 0 || j >= 0 || carry != 0) { 
            
                int sum = carry;
                if (i >= 0) {
                    sum += arr1[i];
                    i--;
                }

                if (j >= 0) {
                    sum += arr2[j];
                    j--;
                }
                ans.Add(sum % 10);
                carry = sum / 10;
            } 
            ans.Reverse();
            Console.WriteLine("The sum of the two arrays is: " + string.Join(", ", ans));
        }
    }
}
/* Given Arrays 
 
int[] arr1 = { 1, 2, 3, 4 };
int[] arr2 = { 5, 6, 7 };

Expected Output:

The sum of the two arrays is: 1, 8, 0, 1

*/