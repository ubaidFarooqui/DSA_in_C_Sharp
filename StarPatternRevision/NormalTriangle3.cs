using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatternRevision
{
    public class NormalTriangle3
    {
        public void normalTriangle3()
        {
            Console.Write("Enter rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<=rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}