using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingExam
{
    internal class DataStructures
    {
        // Метод reverseArray переворачивает массив целых чисел.
        public static List<int> reverseArray(List<int> a)
        {
            List<int> reverseArr = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                reverseArr.Add(a[a.Count - i - 1]);
            }
            return reverseArr;
        }

        public static List<int> rotateLeft(int d, List<int> arr)
        {
            for (int i = 0; i < d; i++)
            {
                arr.Add(arr[0]);
                arr.RemoveAt(0);
            }
            return arr;
        }
    }
}
