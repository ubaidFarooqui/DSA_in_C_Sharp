using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class BubbleSort
    {
        public void bubbleSort(int[] arr) {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++) {
                for (int j = 0; j < arr.Length; j++) { 
                  if (arr[i] < arr[j]) { 
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("sorted Array: " + string.Join(", ", arr));
        }
    }
}
