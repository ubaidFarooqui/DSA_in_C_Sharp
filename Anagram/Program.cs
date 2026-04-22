using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anagram;
public class Program
{
    static void Main(string[] args)
    {
        string word1 = "listen";
        string word2 = "silent";
        AnagramProblem problem = new AnagramProblem();
        Console.WriteLine(problem.solve(word1.ToCharArray(),word2.ToCharArray()));
    }
}