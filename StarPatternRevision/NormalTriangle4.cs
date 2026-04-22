using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatternRevision
{
    public class NormalTriangle4
    {
        public void normalTriangle4()
        {
            Console.Write("Enter rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
               for (int j = 1; j <= n; j++)
                {
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
