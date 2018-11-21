using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2a
{

    // 2.а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1.
    // Константин Суворов. Санкт-Петербург.

    static class MyArray
    {
        static int[] a;
        public static int [] FillArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
            return a;
        }

        public static int NumberOfPairDivThree(int[] a)
        {
            int count = 0;
            int i;
            int divider = 3;
            for (i = 0; i < a.Length - 1; i++)
                if (a[i] % divider == 0 | a[i + 1] % divider == 0) count++;
            return count;
        }

        public static string ToString()
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
            //MyArray.FillArray(20, -10000, 10000);
            int[] a = MyArray.FillArray(20, -10000, 10000);
            MyArray.NumberOfPairDivThree(a);
            Console.WriteLine($"Массив с 20-ю элементами, заполненный случайными числами: {MyArray.ToString()}\nКоличество пар элементов массива, в которых только одно число делится на 3: {MyArray.NumberOfPairDivThree(a)}");
            Console.ReadKey();
        }
    }
}
