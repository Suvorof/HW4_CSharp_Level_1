using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    // 2) ���������� ������ 1 � ���� ������������ ������ StaticClass;
    // ���������� �������. �����-���������.

    static class MyArray
    {
        static int n = 20, min = -10000, max = 10000;
        static int[] a;
        public static void FillArray()
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        public static int NumberOfPairDivThree
        {
            get
            {
                int count = 0;
                int i;
                int divider = 3;
                for (i = 0; i < a.Length - 1; i++)
                    if (a[i] % divider == 0 | a[i + 1] % divider == 0) count++;
                return count;
            }
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
            MyArray.FillArray();
            Console.WriteLine($"������ � 20-� ����������, ����������� ���������� �������: {MyArray.ToString()}\n���������� ��� ��������� �������, � ������� ������ ���� ����� ������� �� 3: {MyArray.NumberOfPairDivThree}");
            Console.ReadKey();
        }
    }
}
