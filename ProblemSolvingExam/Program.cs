using System;
using System.Collections.Generic;
namespace ProblemSolvingExam
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(string.Join(" ", DataStructures.reverseArray(new List<int> {3, 6,9,12,15 })));
            Console.ReadLine();
        }
    }
}
