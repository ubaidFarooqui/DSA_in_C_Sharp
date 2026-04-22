using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatternRevision
{
    public class NormalTriangle2
    {
        public void NormalTriangle2Print()
        {
            Console.Write("Enter rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                for (int j = 1; j <= n - i + 1; j++) { 
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
