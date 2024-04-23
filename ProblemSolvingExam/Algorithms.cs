﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblemSolvingExam
{
    class Algorithms
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


        // Метод divisibleSumPairs считает количество пар чисел в массиве, сумма которых делится на k.
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            // Инициализируем переменную pairsCount для хранения количества подходящих пар и устанавливаем ее равной 0.
            int pairsCount = 0;

            // Внешний цикл проходит по элементам массива от 0 до n - 1.
            for (int i = 0; i < ar.Count; i++)
            {
                // Внутренний цикл проходит по элементам массива до текущего индекса i.
                for (int j = 0; j < i; j++)
                {
                    // Если сумма элементов ar[i] и ar[j] делится на k без остатка, увеличиваем счетчик pairsCount на 1.
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        pairsCount++;
                    }
                }
            }

            // Возвращаем количество подходящих пар.
            return pairsCount;
        }


        // Метод kangaroo проверяет, встретятся ли кенгуру в будущем.
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            // Проверяем, если второй кенгуру движется так же или быстрее первого,
            // то первый кенгуру никогда не догонит второго. Возвращаем "NO".
            if (v2 >= v1)
                return "NO";

            // Проверяем, если разность начальных позиций кенгуру кратна разности их скоростей,
            // то они встретятся в какой-то момент времени. Возвращаем "YES".
            return (x1 - x2) % (v2 - v1) == 0 ? "YES" : "NO";
            // Формула (x1 - x2) % (v2 - v1) проверяет, делится ли разность начальных позиций кенгуру
            // на разность их скоростей без остатка. Если да, это значит, что кенгуру встретятся
            // в какой-то момент времени. В противном случае, они никогда не встретятся.

            // Пример 1:
            // Пусть первый кенгуру начинает с позиции 0 и прыгает на 2 метра за прыжок,
            // а второй кенгуру начинает с позиции 5 и прыгает на 3 метра за прыжок.
            // Разность начальных позиций (x1 - x2) = 0 - 5 = -5,
            // а разность скоростей (v2 - v1) = 3 - 2 = 1.
            // -5 делится на 1 без остатка, поэтому кенгуру встретятся. Возвращаем "YES".

            // Пример 2:
            // Пусть первый кенгуру начинает с позиции 0 и прыгает на 2 метра за прыжок,
            // а второй кенгуру начинает с позиции 5 и прыгает на 2 метра за прыжок.
            // Разность начальных позиций (x1 - x2) = 0 - 5 = -5,
            // а разность скоростей (v2 - v1) = 2 - 2 = 0.
            // -5 не делится на 0 без остатка, поэтому кенгуру никогда не встретятся. Возвращаем "NO".

            //Кроме того есть несколько вариаций формул:
            // 1. (x1 - x2) % (v2 - v1)
            // 2. (x2 - x1) % (v2 - v1)
            // 3. (x1 - x2) % (v1 - v2)
            // 4. (x2 - x1) % (v1 - v2)

            //Важно, чтобы знаки разностей позиций и скоростей были согласованы.
            //В противном случае, результат проверки может быть непредсказуемым.
        }

        // Метод viralAdvertising моделирует процесс распространения рекламы в социальных сетях.
        // При этом каждый человек, видевший рекламу, делится ей с тремя друзьями,
        // но только половина из них реагирует на нее.
        // Задача метода - определить общее количество людей, которые увидят рекламу за n дней.
        public static int viralAdvertising(int n)
        {
            // Инициализируем переменные для хранения количества лайков и общего числа людей,
            // которые увидели рекламу.
            int totalLikes = 0;
            int viewers = 5; // Начальное количество людей, которые видят рекламу.

            // Моделируем процесс распространения рекламы в течение n дней.
            for (int day = 1; day <= n; day++)
            {
                // Вычисляем количество людей, которые лайкнули рекламу (половина от числа людей, которые ее увидели).
                int likesToday = viewers / 2; // Например, если viewers = 5, то likesToday будет равен 5 / 2 = 2.

                // Обновляем общее количество людей, которые увидели рекламу за текущий день.
                totalLikes += likesToday; // Например, если likesToday = 2, то totalLikes увеличится на 2.

                // Каждый человек, видевший рекламу, делится ей с тремя друзьями.
                // Например, если сегодня увидели рекламу 5 человек, то на следующий день 5 * 3 = 15 человек увидят рекламу.
                // Однако только половина из этих 15 человек (округленная вниз) реагируют на рекламу и становятся новыми зрителями.
                viewers = likesToday * 3;
                // Например, если likesToday = 2, то viewers будет равен 2 * 3 = 6 на следующий день.
            }

            // Возвращаем общее количество людей, которые увидят рекламу за n дней.
            return totalLikes;
        }


        // Метод utopianTree моделирует рост дерева за несколько сезонов. 
        // В каждом весеннем цикле высота дерева удваивается, а в летнем увеличивается на 1 метр.
        // Начальная высота дерева - 1 метр.
        public static int utopianTree(int n)
        {
            // Инициализируем переменную для хранения высоты дерева и устанавливаем ее равной 1.
            int h = 1;

            // Выполняем цикл для каждого сезона, начиная с первого сезона.
            for (int i = 0; i < n; i++)
            {
                // Если номер сезона четный (лето), увеличиваем высоту дерева на 1 метр.
                // В противном случае (нечетный, весна), удваиваем высоту дерева.
                h = i % 2 == 0 ? h *= 2 : ++h;
            }
            // Возвращаем высоту дерева после выполнения всех сезонов.
            return h;
        }

        // Этот метод определяет, правильно ли Брайан рассчитал счет в ресторане.
        // Если счет справедливо разделен, выводится сообщение "Bon Appetit".
        // В противном случае выводится разница между суммой, взятой с Анны, и справедливой стоимостью.
        public static void bonAppetit(List<int> bill, int k, int b)
        {
            // Сначала мы удаляем элемент с индексом k из списка bill.
            bill.Remove(bill[k]);

            // Затем мы вычисляем справедливую стоимость, которая представляет собой половину
            // суммы стоимостей оставшихся предметов в списке bill.
            int fairPrice = bill.Sum() / 2;

            // Если разница между суммой, взятой с Анны, и справедливой стоимостью равна 0,
            // это означает, что счет справедливо разделен, и мы выводим сообщение "Bon Appetit".
            // В противном случае мы выводим разницу между этими значениями, что указывает
            // на сумму, которую Брайан должен вернуть Анне.
            if (b - fairPrice == 0)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b - fairPrice);
            }
        }


        // Метод anagram определяет минимальное количество символов, которые нужно изменить,
        // чтобы сделать две подстроки строки s анаграммами друг друга.
        // Если длина строки s нечетная, метод возвращает -1, так как строку невозможно разделить на две равные части.
        // Иначе метод возвращает количество символов, которые нужно изменить.
        public static int anagram(string s)
        {
            // Проверяем, что длина строки s четная.
            if (s.Length % 2 != 0)
                return -1;

            // Инициализируем переменную для подсчета изменений.
            int changesCount = 0;

            // Разделяем строку s на две равные части: первую и вторую.
            string firstPart = s.Substring(0, s.Length / 2);
            string secondPart = s.Substring(s.Length / 2);

            // Для каждой буквы в первой части строки firstPart проверяем, содержится ли она во второй части secondPart.
            // Если содержится, удаляем эту букву из второй части.
            // Если не содержится, увеличиваем счетчик changesCount на 1.
            foreach (char letter in firstPart)
            {
                // Ищем индекс текущей буквы во второй части строки secondPart.
                int index = secondPart.IndexOf(letter);

                // Если буква найдена во второй части строки, удаляем ее.
                if (index != -1)
                {
                    secondPart = secondPart.Remove(index, 1);
                }
                // Если буква не найдена, увеличиваем счетчик изменений.
                else
                {
                    changesCount++;
                }
            }

            // Возвращаем количество символов, которые нужно изменить.
            return changesCount;
        }

        // Этот метод находит минимальное расстояние между двумя одинаковыми элементами в массиве.
        // Минимальное расстояние - это количество индексов между этими элементами.
        // Если в массиве нет одинаковых элементов, функция должна вернуть -1.
        public static int minimumDistances(List<int> a)
        {
            // Создаем список для хранения расстояний между одинаковыми элементами.
            List<int> distances = new List<int>();

            // Первый цикл перебирает каждый элемент массива.
            for (int i = 0; i < a.Count; i++)
            {
                // Второй цикл также перебирает каждый элемент массива.
                // Он используется для поиска другого элемента с тем же значением, что и текущий элемент.
                for (int j = 0; j < a.Count; j++)
                {
                    // Если находим два одинаковых элемента, вычисляем расстояние между ними и добавляем его в список.
                    if (a[i] == a[j])
                    {
                        distances.Add(Math.Abs(j - i));
                    }
                }
            }

            // Метод Any используется для проверки, содержит ли список расстояний хотя бы один элемент.
            // Если список пуст, значит, одинаковые элементы не были найдены, и возвращается -1.
            // В противном случае возвращается минимальное значение из списка.
            if (distances.Any())
            {
                return distances.Min();
            }
            else
            {
                return -1;
            }
        }


        // Этот метод вычисляет факториал заданного целого числа и выводит его значение.
        // В качестве параметра он принимает целое число n.
        public static void extraLongFactorials(int n)
        {
            // Инициализируем переменную num значением 1, так как умножение на 1 не изменит результат.
            BigInteger num = 1;

            // Выполняем цикл, пока n больше 1, потому что факториал 0 и 1 равен 1, и дальнейшее умножение будет бесполезным.
            while (n > 1)
            {
                // Умножаем текущее значение num на значение n и сохраняем результат в num.
                num *= n;

                // Уменьшаем значение n на 1 для перехода к следующему числу в последовательности.
                n--;
            }

            //Второй вариант цикла(через for)
            //for (int i = n; i > 1; i--)
            //{
            //    num *= i;
            //}

            // Выводим вычисленное значение факториала.
            Console.WriteLine(num);
        }


        // Метод findDigits вычисляет количество цифр в числе, которые делят само число.
        public static int findDigits(int n)
        {
            // Инициализируем переменную count, которая будет хранить количество цифр, делящих число n.
            int count = 0;

            // Преобразуем число n в строку для удобства обращения к его цифрам.
            string nStr = n.ToString();

            // Перебираем все цифры числа n.
            for (int i = 0; i < nStr.Count(); i++)
            {
                // Получаем текущую цифру числа n.
                // Для получения числового значения текущего символа вычитаем код символа '0' из кода текущего символа.
                // Например, символ '5' имеет код ASCII 53, а символ '0' - 48. 
                // Путем вычитания получаем числовое значение 5.
                int digit = nStr[i] - '0';

                // Проверяем, не является ли текущая цифра нулем
                // и делится ли само число n на эту цифру без остатка.
                // Если условие выполняется, увеличиваем счетчик на 1.
                if (digit != 0 && n % digit == 0)
                {
                    count++;
                }
            }

            return count;
        }

        // Метод pairs принимает на вход целочисленное значение k и список целочисленных значений arr.
        // Он вычисляет количество пар элементов массива arr, для которых разность между элементами равна k.
        public static int pairs(int k, List<int> arr)
        {
            // Создаем хэш-сет hasSet, который содержит все уникальные элементы списка arr.
            HashSet<int> hasSet = new HashSet<int>(arr);


            // Для каждого элемента p из списка arr, проверяем, содержит ли hasSet элемент p + k.
            return arr.Count(p => hasSet.Contains(p + k));
            //Допустим, у нас есть список чисел [3, 6, 9, 12, 15] и k = 3.

            //Для p = 3, проверяем, содержит ли хэш-сет число 3 + 3 = 6.Да, содержит.
            //Для p = 6, проверяем, содержит ли хэш-сет число 6 + 3 = 9.Да, содержит.
            //Для p = 9, проверяем, содержит ли хэш-сет число 9 + 3 = 12.Да, содержит.
            //Для p = 12, проверяем, содержит ли хэш-сет число 12 + 3 = 15.Да, содержит.
            //Для p = 15, проверяем, содержит ли хэш-сет число 15 + 3 = 18.Нет, не содержит.
        }


    }
}
