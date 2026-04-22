using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPrint
{
    public class Rhombus
    {
        public void rhombus()
        {
            Console.Write("Enter rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int  i = 1; i<=rows;  i++)
            {
                for (int j = 1; j <= rows - i; j++) { 
                    Console.Write("  ");
                }

                for (int j = 1; j <= rows; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

/* Expected Output:
 
Enter rows: 6
          * * * * * *
        * * * * * *
      * * * * * *
    * * * * * *
  * * * * * *
Explaination: it is combine code of square stars and star triangle vertically flipped
*/
