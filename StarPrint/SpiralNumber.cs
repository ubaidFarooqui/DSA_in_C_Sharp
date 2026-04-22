using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPrint
{
    public class SpiralNumber
    {
        public void spiralNumber()
        {
            Console.Write("Enter rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 2*n - 1; i++)
            {
                for (int j = 1; j <= 2*n -1; j++)
                {
                    int a = i; int b = j;
                    if (i > n) 
                    {
                        a = 2 * n - i;
                    }
                    if (j > n)
                    {
                        b = 2 * n - j;
                    }
                    Console.Write(Math.Min(a, b) + " ");
                }
                Console.WriteLine();
            }
        }
    }  
}