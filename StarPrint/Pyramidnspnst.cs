using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPrint
{
    public class Pyramidnspnst
    {
        public void pyramidnspnst()
        {
            Console.Write("Enter rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int nsp = n - 1;
            int nst = 1;

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
        }
    }
}

/* Expected Output:
in start:
number of spaces => nsp = n -1
number of stars => nst = 1

Enter rows: 6
          *
        * * *
      * * * * *
    * * * * * * *
  * * * * * * * * *
* * * * * * * * * * *


*/