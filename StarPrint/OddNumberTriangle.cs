using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPrint
{
    public class OddNumberTriangle
    {
        public void oddNumberTriangle()
        {
            Console.Write("Enter rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((2 * j - 1) + " ");
                }
                
                Console.WriteLine();
            }
        }
    }
}
/*
 Expected Output:
 Enter rows: 6
    1
    1 3
    1 3 5
    1 3 5 7
    1 3 5 7 9
    1 3 5 7 9 11
 */
