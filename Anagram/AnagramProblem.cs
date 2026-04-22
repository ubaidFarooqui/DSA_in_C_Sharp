using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class AnagramProblem
    {
        public bool solve(char[] s1, char[] s2) 
        {
            if (s1.Length != s2.Length) 
            {
                return false;
            }
            // sort the letter of the strings
            // O(n log n) time complexity
            Array.Sort(s1);
            Array.Sort(s2);

            //consider all the letters one by one and we have to compare them
            for (int i = 0; i < s1.Length; i++) 
            {
             if (s1[i] != s2[i]) 
                {
                    return false;
                }
            }
            return true;
        }
     }
 }

