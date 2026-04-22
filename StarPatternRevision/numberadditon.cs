using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatternRevision
{
    public class numberadditon
    {
        public void numberaddition()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = n;
            for (int i = 1; i < 5; i++)
            {
                sum += 2; 
            }
            Console.WriteLine($"Sum is: {sum}");
        }
    }
}
