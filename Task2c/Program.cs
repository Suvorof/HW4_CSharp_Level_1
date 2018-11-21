using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task2c
{
    // 2.c**) Добавьте обработку ситуации отсутствия файла на диске.
    // Константин Суворов. Санкт-Петербург.

    static class MyArray
    {
        public static void StreamReader()
        {
            int[] a;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("C:\\Users\\Konstantin\\Desktop\\data.txt");
                int n = int.Parse(sr.ReadLine());
                a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    int b = int.Parse(sr.ReadLine());
                    a[i] = b;
                    Console.Write($"{b} ");
                }
                // Освобождаем файл data.txt для использования другими программами.
                sr.Close();
                }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
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
