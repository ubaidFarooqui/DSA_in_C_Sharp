using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPrint
{
    public class alpabhetPrint
    {
        public void alpabhetPrinting()
        {
                Console.Write("Enter rows: ");
                int rows = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter columns: ");
                int colums = Convert.ToInt32(Console.ReadLine());
            //char ch = 'A';
            for (int i = 0; i < rows; i++)
                 {
                    //char ch = 'A';
                    for (int j = 1; j < i; j++)
                        {
                         Console.Write((char)(j + 64) +  " ");
                         //ch++;
                        }
                    Console.WriteLine();
            }
        }
    }
}