using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    // 1) Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые
    // значения от –10 000 до 10 000 включительно.Заполнить случайными числами. Написать
    // программу, позволяющую найти и вывести количество пар элементов массива, в которых только
    // одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих
    // элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
    // Константин Суворов. Санкт-Петербург.

    class MyArray
    {
        int[] a;
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        public int NumberOfPairDivThree
        {
            get
            {
                int count = 0;
                int i;
                int divider = 3;
                for (i = 0; i < a.Length-1; i++)
                    if (a[i] % divider == 0 | a[i + 1] % divider == 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
    class Program
    {
        static void Main()
        {
            MyArray a = new MyArray(20, -10000, 10000);
            Console.WriteLine($"Массив с 20-ю элементами, заполненный случайными числами: {a.ToString()}\nКоличество пар элементов массива, в которых только одно число делится на 3: {a.NumberOfPairDivThree}");
            Console.ReadKey();
        }
    }
}
