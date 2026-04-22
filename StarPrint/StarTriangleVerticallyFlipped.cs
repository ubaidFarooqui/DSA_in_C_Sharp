using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StarPrint
{
    public class StarTriangleVerticallyFlipped
    {
        public void starTriangleVerticallyFlipped()
        {
            //Method 1
            //Console.Write("Enter rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= rows; j++)
            //    {
            //        if ((i + j) > rows)
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //Method 2
            //Console.Write("Enter rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= rows - i; j++)
            //    {
            //        Console.Write("  ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();

            //}
            // For Numbers 
            //Console.Write("Enter rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= rows - i; j++)
            //    {
            //        Console.Write("  ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();

            //}
            // For Alphabets
            //Console.Write("Enter rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= rows - i; j++)
            //    {
            //        Console.Write("  ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write((char)(i + 64) + " ");
            //    }
            //    Console.WriteLine();

            //}

            // For small and capital alphabets row by row
            //Console.Write("Enter rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= rows - i; j++)
            //    {
            //        Console.Write("  ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % 2 == 1)
            //        {
            //            Console.Write((char)(i + 96) + " ");
            //        }
            //        else {
            //            Console.Write((char)(i + 64) + " ");
            //        }
                   
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            Console.Write("Enter rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write(j + " ");
                    }
                    else
                    {
                        Console.Write((char)(j + 64) + " ");
                    }

                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
/*
expected output:

enter rows: 6
          *
        * *
      * * *
    * * * *
  * * * * *
* * * * * *

Method 2:
this the loop logic for method 2 to print spaces:
 j< colums + 1 - i but here it will be j<rows-1

Expected output for numbers:
Enter rows: 6
          1
        1 2
      1 2 3
    1 2 3 4
  1 2 3 4 5
1 2 3 4 5 6

Expected output for alphabets:
Enter rows: 6
          A
        B B
      C C C
    D D D D
  E E E E E
F F F F F F

Expected output for small alphabets and capital alphabets row by row:

Enter rows: 6
          a
        B B
      c c c
    D D D D
  e e e e e
F F F F F F

Expected output for numbes and alphabets row by row:

Enter rows: 6
          1
        A B
      1 2 3
    A B C D
  1 2 3 4 5
A B C D E F


 */