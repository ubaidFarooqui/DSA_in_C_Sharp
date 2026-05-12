using Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class Program
    {
        static void Main(string[] args)
        {
            //NegativeNumbers negativeNumbers = new NegativeNumbers();
            //negativeNumbers.negativeNumbers();

            //SumOfAnArrray sumOfAnArrray = new SumOfAnArrray();
            //sumOfAnArrray.sumOfAnArray();

            //ProductofanArray productofanArray = new ProductofanArray();
            //productofanArray.productofanArray();

            //MaxNumberinArray maxNumberinArray = new MaxNumberinArray();
            //maxNumberinArray.maxNumberArray();

            //PassingArrayToMethod passingArrayToMethod = new PassingArrayToMethod();
            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(arr[2]);
            //passingArrayToMethod.arrChange(arr);
            //Console.WriteLine(arr[2]);

            //AddMultiply addMultiply = new AddMultiply();
            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine("Original array: " + string.Join(", ", arr));
            //addMultiply.addMultiply(arr);
            //Console.WriteLine("Modified array: " + string.Join(", ", arr));

            int[] arr = { 1, 2, -3, 0, 9 };
            //Console.WriteLine("Unsorted array: " + string.Join(", ", arr));
            //Console.Write("Enter a number to check if it exists in the array: ");

            //int n = Convert.ToInt32(Console.ReadLine());
            //ExitsinArray existinArray = new ExitsinArray();
            //existinArray.existinArray(arr, n);

            //BubbleSort bubbleSort = new BubbleSort();
            //bubbleSort.bubbleSort(arr);
            //Console.ReadKey();

            //SeconMaxNumberInArray seconMaxNumberInArray = new SeconMaxNumberInArray();
            //seconMaxNumberInArray.secondMaxNumberinArray(arr);
            //Console.WriteLine("Original array: " + string.Join(", ", arr));

            //ReverseArray reverseArray = new ReverseArray();
            //reverseArray.reverseArray(arr);
            //Console.WriteLine("Reversed array: " + string.Join(", ", arr));

            RotateArray rotateArray = new RotateArray();
            Console.WriteLine("Original array: " + string.Join(", ", arr));
            rotateArray.rotateArray(arr, 2);
            Console.WriteLine("Rotated array: " + string.Join(", ", arr));

            ///int[] arr2 = [1, 2, 3, 4, 5, 6, 8]; // 7 is missing
            //MissingNunmberInArray missingNunmberInArray = new MissingNunmberInArray();
            //missingNunmberInArray.missingNumberInAray(arr2);

            //int[] arr0and1 =  { 0, 1, 0, 1, 1, 0, 0, 1 };
            //Segregate0and1 segregate0and1 = new Segregate0and1();
            //segregate0and1.segregate0and1(arr0and1);

            Console.ReadKey();


        }
    }  
}