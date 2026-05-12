using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ReverseArray
    {
        public void reverseArray(int[] arr) {
            int low_Index = 0;
            int high_Index = arr.Length - 1;

            while (low_Index < high_Index)
            {
                swap(arr, low_Index, high_Index);
                low_Index++;
                high_Index--;   
            }
            
        }
        private void swap(int[] arr, int lower_index, int higher_Index)
        {
          int temp = arr[lower_index];
          arr[lower_index] = arr[higher_Index];
          arr[higher_Index] = temp;
        }
    }
}
