using System;

namespace _4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов N:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Исходный масив:");
            int[] a = new int[N];
            Random r = new Random();
            for (int i = 0; i < N; i++)
            {
                a[i] = r.Next(1, 10);
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine("\t");
            int x = 0;
            Console.WriteLine("Изменённый масив:");
            for (int i = 1; i < N; i++)
            {

            }
        }
    }
}
