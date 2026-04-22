using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPrint
{
    class Factorial
    {
        public int factorial(int n)
        {
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + n + " is: " + fact);
            return fact;
        }
    }
}
