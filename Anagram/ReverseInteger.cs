using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class ReverseInteger
    {
        public void reverseInteger(int num)
        {
            int reversed = 0;
            while (num != 0) {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num = num / 10; // remove the last digit from the number
            }
            Console.WriteLine("The reverse of the given number is: " + reversed);
            
        }
    }
}
