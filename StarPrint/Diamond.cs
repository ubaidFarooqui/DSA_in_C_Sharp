using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPrint
{
    public class Diamond
    {
        public void DiamondPrint()
        {
            Console.Write("Enter rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int nsp = n - 1;
            int nst = 1;
            // for upper Diamond
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= nsp; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= nst; j++)
                {
                    Console.Write("* ");
                }
                nsp--; // after each iteration number of spaces will be reduced by 1
                nst = nst + 2; // after each iteration number of stars will be increased by 2
                Console.WriteLine();
            }
            // for lower Diamond
            nsp = 1;
            nst = 2*n -3;
            for (int i = 1; i <= n-1; i++) // for n-1 rows because we have already printed the middle row in upper Diamond
            {
                for (int j = 1; j <= nsp; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= nst; j++)
                {
                    Console.Write("* ");
                }
                nsp++; 
                nst = nst - 2; 
                Console.WriteLine();
            }
        }
    }
}

/*
 Expected Output:
 Enter rows: 6
          *
        * * *
      * * * * *
    * * * * * * *
  * * * * * * * * *
* * * * * * * * * * *
  * * * * * * * * *
    * * * * * * *
      * * * * *
        * * *
          *
*/