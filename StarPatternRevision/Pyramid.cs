using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatternRevision
{
    public class Pyramid
    {
        public void pyramid() { 
            Console.Write("Enter rows: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int nsp = n - 1;
            int nst = 1;

            for (int i = 1; i <= n; i++) {
                for (int j= 1; j <= nsp; j++) {
                    Console.Write("  ");
                }

                for (int j = 1; j <= nst; j++) { 
                    Console.Write("* ");
                }
                nsp--;
                nst += 2;
                Console.WriteLine();
            }
           
        }
    }
}
