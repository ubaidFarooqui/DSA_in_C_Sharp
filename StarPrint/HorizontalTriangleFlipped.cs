using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPrint
{
    public class HorizontalTriangleFlipped
    {
        public void horizontalTriangleFlipped()
        {

            Console.Write("Enter rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter columns: ");
            int colums = Convert.ToInt32(Console.ReadLine());
            //int a = colums;
            for (int i = 1; i <= rows; i++)
            {
                //for (int j = 1; j <=a; j++)
                for (int j = 1; j <= colums+1-i; j++)
                {
                    Console.Write(j + " ");
                }
                //a--;
                Console.WriteLine();
            }
}
    }
}

// i + jmax = colums + 1
// jmax = colums + 1 - i is one more logic to print this pattern, the loop will be for (int j = 1; j <= colums+1-i; j++)
/* Expected Output
Enter rows: 6
Enter columns: 6
1 2 3 4 5 6
1 2 3 4 5
1 2 3 4
1 2 3
1 2
*/