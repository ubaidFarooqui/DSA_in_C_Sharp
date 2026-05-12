using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[] { 1, 2, 3, 4, 5 };
            ReverseArrayProblem problem = new ReverseArrayProblem();
            Console.WriteLine(string.Join(", ", problem.Solve(ints)));
           
        }
    }
}
 