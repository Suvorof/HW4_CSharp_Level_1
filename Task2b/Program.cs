using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2b
{
    // 2.�*) �������� ����������� ����� ��� ���������� ������� �� ���������� �����. ����� ������ ���������� ������ ����� �����;
    // ���������� �������. �����-���������.

    static class MyArray
    {
        static int[] a;
        public static int[] FillArray(int n, int min, int max)
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
        public static int [] StreamReader()
        {
            // ������� ������ sr � ��������� ��� � ������ data.txt.
            StreamReader sr = new StreamReader("C:\\Users\\Konstantin\\Desktop\\data.txt");
            // ������� ���������� �����.
            int n = int.Parse(sr.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                int b = int.Parse(sr.ReadLine());
                a[i] = b;
                Console.Write($"{b} ");
            }
            // ����������� ���� data.txt ��� ������������� ������� �����������.
            sr.Close();
            return a;
        }

    }

    class Program
    {
        static void Main()
        {
            MyArray.StreamReader();
            Console.ReadKey();
        }
    }
}
