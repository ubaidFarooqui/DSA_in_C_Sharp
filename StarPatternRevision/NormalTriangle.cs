using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatternRevision
{
     public class NormalTriangle
    {
        public void normalTriangle() { 
            Console.Write("Enter rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                for (int j = 1; j <= i; j++) { 
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
