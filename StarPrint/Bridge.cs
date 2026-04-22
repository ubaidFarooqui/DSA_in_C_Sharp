using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPrint
{
    public class Bridge
    {
        public void bridge()
        {
            Console.Write("Enter rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int nsp = 1;
            for (int i = 1; i<= 2*n-1; i++) { //for first line we have to print 2*n-1 stars
                Console.Write("* ");
            }
            Console.WriteLine();

            for (int i = 1; i <= n-1; i++) { //lines
                for (int j = 1; j <= n - i; j++) { //stars
                    Console.Write("* ");
                }

                for (int j = 1; j <= nsp; j++) { //spaces
                    Console.Write("  ");
                }
                          
                for (int j = 1; j <= n - i; j++) { //stars
                    Console.Write("* ");
                }
                nsp += 2; // after each iteration number of spaces will be increased by 2 
                Console.WriteLine();
            }
        }
    }
}

/*
 Expected Output:
 Enter rows: 6

* * * * * * * * * * *
* * * * *   * * * * *
* * * *       * * * *
* * *           * * *
* *               * *
*                   *
inner 1st and 3rd loop are the same

*/

