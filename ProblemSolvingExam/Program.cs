using System;
using System.Collections.Generic;
namespace ProblemSolvingExam
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(string.Join(" ", DataStructures.rotateLeft(1, new List<int> {3, 6, 9, 12,15 })));
            Console.ReadLine();
        }
    }
}
