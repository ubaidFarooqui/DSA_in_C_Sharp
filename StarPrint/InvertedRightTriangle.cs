using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPrint
{
    public class InvertedRightTriangle
    { 
        public void invertedRightTriangle() { 
            Console.Write("Enter rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int  i=1;  i<= rows; i++)
            {
                for (int j = 1; j <= rows; j++) {
                    if (j < i) {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}

/* Expected Output:

Enter rows: 6
* * * * * *
  * * * * *
    * * * *
      * * *
        * *
          *
But with this line Console.Write(" ") means reducing the space between the stars, so the output will be like this: 

Enter rows: 6
* * * * * *
 * * * * *
  * * * *
   * * *
    * *
     *
*/