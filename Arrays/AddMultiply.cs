using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class AddMultiply
    {
        public void addMultiply(int[] arr) {

            for (int i = 0; i < arr.Length; i++) {
                if (i % 2 == 1)
                {
                    arr[i] = arr[i] * 2;
                }
                else {
                    arr[i] = arr[i] + 10;
                }
            }
        }
    }
}
