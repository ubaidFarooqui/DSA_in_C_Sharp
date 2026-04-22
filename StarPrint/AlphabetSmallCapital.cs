using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPrint
{
    public class AlphabetSmallCapital
    {
      public void alphabetSmallCapital()
        {
            Console.Write("Enter rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter rows: ");
            int colums = Convert.ToInt32(Console.ReadLine());
        
            for (int i = 1; i <= rows; i++) {
                for (int j = 1; j <= colums; j++)
                {
                    if (i % 2 == 1) {
                        Console.Write((char)(j + 96) + " ");
                    }
                    else
                    {
                        Console.Write((char)(j + 64) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
/* Expected Output:
Enter rows: 6
Enter rows: 6
a b c d e f
A B C D E F
a b c d e f
A B C D E F
a b c d e f
A B C D E F
 */
