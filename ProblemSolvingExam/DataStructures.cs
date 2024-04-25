using System.Collections.Generic;
using System;


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
        // Метод rotateLeft сдвигает каждый элемент массива на 1 единицу влево.
        // Учитывая целое число d, нужно повернуть массив.
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
