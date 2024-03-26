using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblemSolvingExam
{
    class ProblemSolving
    {

        // Функция miniMaxSum принимает список целых чисел и находит минимальную и максимальную суммы,
        // складывая ровно четыре из пяти чисел.
        public static void miniMaxSum(List<int> arr)
        {
            // Сортируем массив для удобства работы с ним
            // Это позволит нам рассматривать наименьшие
            // и наибольшие числа в начале и конце массива соответственно.
            arr.Sort();

            // Инициализируем переменные для минимальной и максимальной сумм.
            long minSum = 0;
            long maxSum = 0;

            // Проходим по массиву, суммируя четыре наименьших и четыре наибольших числа.
            // Для этого мы суммируем все элементы, кроме самого большого (для минимальной суммы)
            // и самого маленького (для максимальной суммы).
            for (int i = 0; i < arr.Count - 1; i++)
            {
                minSum += arr[i];
                maxSum += arr[i + 1];
            }

            // Выводим минимальную и максимальную суммы.
            Console.WriteLine($"{minSum} {maxSum}");
        }


        // Метод diagonalDifference принимает двумерный список целых чисел и вычисляет
        // абсолютную разницу между суммами его диагоналей.
        public static int diagonalDifference(List<List<int>> arr)
        {
            // Инициализируем переменные для сумм левой и правой диагоналей.
            int diagLeft = 0;
            int diagRight = 0;

            // Проходим по матрице, суммируя элементы по левой и правой диагонали.
            for (int i = 0; i < arr.Count; i++)
            {
                diagLeft += arr[i][i];
                diagRight += arr[i][arr.Count - i - 1];
            }

            // Возвращаем абсолютную разницу между суммами диагоналей.
            return Math.Abs(diagLeft - diagRight);
        }

        // Метод DrawStairs рисует лестницу заданного размера:
        //    #
        //   ##
        //  ###
        // ####
        public static void DrawStairs(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //n - это общее количество ступенек в лестнице
                    //i - это номер текущей ступеньки(начиная с 0)
                    //j - это индекс символа в строке текущей ступеньки
                    //-1 используется для того, чтобы учесть, что индексация начинается с 0, а не с 1.
                    //Это позволяет корректно вычислить количество пробелов перед символами # на текущей ступеньке.

                    Console.Write(j < n - i - 1 ? " " : "#");


                    //Когда i = 0(первая ступенька):
                    //Мы должны вывести 4 пробела(так как n - i - 1 = 5 - 0 - 1 = 4) перед символами #
                    //Далее мы выводим один символ #.
                }
                Console.WriteLine();
            }
        }

        // Функция birthdayCakeCandles принимает список целых чисел, представляющих высоты свечей на торте.
        // Она возвращает количество свечей, имеющих максимальную высоту.
        public static int birthdayCakeCandles(List<int> candles)
        {
            // Переменная count используется для подсчета количества свечей с максимальной высотой.
            int count = 0;

            // Находим максимальную высоту свечи в списке
            int maxValue = candles.Max();

            // Проходим по списку свечей и увеличиваем счетчик count для каждой свечи с максимальной высотой.
            foreach (var value in candles)
            {
                if (value == maxValue)
                {
                    count++;
                }
            }

            // Возвращаем количество свечей с максимальной высотой.
            return count;
        }


        // Метод compareTriplets сравнивает оценки Алисы и Боба и возвращает количество баллов для каждого из них.
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            // Инициализируем переменные для подсчета количества баллов Алисы и Боба.
            int countOfMore = 0;
            int countOfLess = 0;

            // Проходим по списку оценок, сравнивая их и увеличивая соответствующий счетчик.
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    countOfMore++;
                }
                else if (a[i] < b[i])
                {
                    countOfLess++;
                }
            }
            // Возвращаем список, содержащий количество баллов Алисы и Боба.
            return new List<int>() { countOfMore, countOfLess };
        }

        // Метод findMedian находит медиану списка чисел.
        public static int findMedian(List<int> arr)
        {
            // Сортируем список чисел
            arr.Sort();

            // Возвращаем элемент, находящийся в середине списка (медиану).
            return arr[arr.Count / 2];
        }


        // Метод missingNumbers находит недостающие числа в списке brr относительно списка arr.
        public static List<int> missingNumbers(List<int> arr, List<int> brr)
        {
            // Удаляем из списка brr все элементы, которые есть в списке arr.
            arr.ForEach(num => brr.Remove(num));

            // Сортируем список brr.
            brr.Sort();

            // Возвращаем список уникальных значений из списка brr.
            return brr.Distinct().ToList();
        }


        // Метод pangrams проверяет, является ли строка панграммой.
        public static string pangrams(string s)
        {
            // Инициализируем переменную для подсчета совпадений с буквами латинского алфавита.
            int matchCount = 0;

            // Проходим по всем уникальным символам строки, приведенным к нижнему регистру.
            foreach (char letter in s.ToLower().Distinct())
            {
                // Проверяем, является ли текущий символ буквой латинского алфавита.
                if (Regex.IsMatch(letter.ToString(), @"[a-z]"))
                {
                    // Если да, увеличиваем счетчик совпадений.
                    matchCount++;
                }
            }

            // Если количество совпадений равно 26 (количество букв в алфавите), строка является панграммой, иначе - нет.
            return matchCount == 26 ? "pangram" : "not pangram";
        }


        // Метод quickSort выполняет разделение массива на три части по заданному опорному элементу (pivot).
        // Возвращает одномерный массив, содержащий элементы слева от pivot, pivot и элементы справа от pivot.
        public static List<int> quickSort(List<int> arr)
        {
            // Инициализируем списки для элементов слева и справа от pivot.
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            // Определяем опорный элемент (pivot).
            int pivot = arr[0];

            // Проходим по массиву, начиная со второго элемента.
            for (int i = 1; i < arr.Count; i++)
            {
                // Если текущий элемент больше pivot, добавляем его в правый список.
                if (arr[i] > pivot)
                    right.Add(arr[i]);
                // Иначе добавляем его в левый список.
                else
                    left.Add(arr[i]);
            }

            // Добавляем pivot в левый список.
            left.Add(pivot);

            // Объединяем левый список, pivot и правый список в один список.
            left.AddRange(right);

            // Возвращаем получившийся список.
            return left;
        }


        // Метод countingSort выполняет сортировку массива arr, используя алгоритм сортировки подсчетом.
        // Возвращает массив, содержащий количество появлений каждого значения в исходном массиве.
        public static List<int> countingSort(List<int> arr)
        {
            // Создаем новый список array, инициализированный нулями, с длиной 100 элементов.
            List<int> array = new List<int>(new int[100]);

            // Для каждого элемента x в исходном массиве arr увеличиваем соответствующий элемент в списке array на 1.
            arr.ForEach(x => array[x]++);

            // Возвращаем полученный список array.
            return array;
        }


        // Метод countingSort2 применяет алгоритм сортировки подсчетом для сортировки списка целых чисел arr.
        // Этот метод сначала создает массив array размером (max + 1), где max - максимальное значение в arr, и заполняет его нулями.
        // Затем для каждого элемента x в arr увеличивает значение array[x].
        // После этого метод создает новый список results и заполняет его значениями в соответствии с количеством вхождений чисел в arr.
        // Наконец, отсортированный список выводится в консоль, а затем возвращается.
        public static List<int> countingSort2(List<int> arr)
        {
            // Находим максимальное значение в массиве arr.
            int max = arr.Max();

            // Создаем новый список array, инициализированный нулями, с длиной (max + 1).
            List<int> array = new List<int>(new int[max + 1]);

            // Создаем новый список results для хранения отсортированных значений.
            List<int> results = new List<int>();

            // "Заполняем" наши "ящики" - увеличиваем значение в array[x] для каждого элемента x в arr.
            arr.ForEach(x => array[x]++);

            // Проверяем каждый "ящик" в array.
            for (int i = 0; i < array.Count; i++)
            {
                // Мы смотрим, сколько раз число i встречается в массиве arr.
                // Затем добавляем число i в список results столько раз, сколько оно встречается.
                for (int j = 0; j < array[i]; j++)
                {
                    results.Add(i);
                }
            }

            // Выводим отсортированный массив в консоль.
            Console.Write(string.Join(" ", results));
            Console.ReadLine();

            // Возвращаем отсортированный массив.
            return results;
        }

        // Метод alternatingCharacters подсчитывает количество символов в строке, которые идут подряд.
        public static int alternatingCharacters(string s)
        {
            int count = 0;

            // Проходим по строке и проверяем каждую пару соседних символов.
            for (int i = 0; i < s.Length - 1; i++)
            {
                // Если два последовательных символа совпадают, увеличиваем счетчик.
                if (s[i] == s[i + 1])
                {
                    count++;
                }
            }
            return count;
        }

        // Метод superReducedString уменьшает строку, удаляя соседние символы, которые совпадают.
        public static string superReducedString(string s)
        {
            bool isReduce = true;
            s = s.ToLower(); // Преобразуем строку в нижний регистр, чтобы учитывать и совпадения в разных регистрах.

            // Пока есть возможность уменьшения строки, продолжаем операции.
            while (isReduce)
            {
                isReduce = false;

                // Проходим по строке, ищем пары соседних символов, которые совпадают.
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] == s[i + 1])
                    {
                        // Если найдена пара совпадающих символов, удаляем их из строки.
                        s = s.Remove(i, 2);
                        isReduce = true; // Устанавливаем флаг, что было проведено уменьшение.
                        break; // Прерываем цикл, чтобы начать проверку с начала строки.
                    }
                }
            }

            // Если строка стала пустой после всех операций, возвращаем "Empty String", иначе возвращаем строку.
            return s == "" ? "Empty String" : s;
        }


        // Метод angryProfessor определяет, будет ли занятие отменено в зависимости от количества студентов, пришедших вовремя.
        public static string angryProfessor(int k, List<int> a)
        {
            // Считаем количество студентов, пришедших вовремя (с отрицательным временем прибытия).
            int studentWhoComeOnTime = a.Count(x => x <= 0);

            // Если количество студентов, пришедших вовремя, меньше заданного порога k, занятие отменяется, иначе - нет.
            return (studentWhoComeOnTime < k) ? "YES" : "NO";
        }

        // Метод stringConstruction возвращает количество уникальных символов в строке s.
        public static int stringConstruction(string s)
        {
            return s.Distinct().Count();
        }

    }
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(ProblemSolving.stringConstruction("aabcd"));
        }
    }
}
