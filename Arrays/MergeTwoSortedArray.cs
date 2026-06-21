using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class MergeTwoSortedArray
    {
        public void MergeArray(int[] c, int[] a, int[] b)
        {
            Console.WriteLine("The first sorted array is: " + string.Join(", ", a));
            Console.WriteLine("The second sorted array is: " + string.Join(", ", b));
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                {
                    c[k] = a[i];  // c[k++] = a[i++] also works, hence i++ in next line not needed
                    i++;
                }
                else
                {
                    c[k] = b[j];
                    j++;          // c[k++] = b[j++] also works, hence j++ in next line not needed
                }
                k++;              // Similary, k++ wouldn't be needed here as well

            }
            if (i == a.Length) { // a array finished, copy the remaining elements of b 
                while (j<b.Length)
                {
                    c[k] = b[j];
                    j++;
                    k++;
                }
            }
            if (j == b.Length) { // b array finished, copy the remaining elements of a
                while (i < a.Length)
                {
                    c[k] = a[i];
                    i++;
                    k++;
                }
            }
                Console.WriteLine("The merged array is: " + string.Join(", ", c));
        }
    }
 }

/*

Given Input:

int[] arr1 = { 1, 3, 5, 7 };
int[] arr2 = { 2, 4, 6, 8, 9 };
int[] arr3 = new int[arr1.Length + arr2.Length];

Expected Output:

The first sorted array is: 1, 3, 5, 7
The second sorted array is: 2, 4, 6, 8, 9
The merged array is: 1, 2, 3, 4, 5, 6, 7, 8, 9
 
*/