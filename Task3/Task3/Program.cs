using System;

namespace Task3
{
    class Program
    {
        static double MultArithmeticElements(int n, double a, int t)
        {
            double[] arr = new double[n];
            arr[0] = a;
            double mult = a;
            for (int i = 1; i < n; i++)
            {
                arr[i] = arr[i-1] + t;
                mult= mult * arr[i];
            }
            return mult;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите a1: ");
            double a1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите t: ");
            int t = int.Parse(Console.ReadLine());

            double Mult = MultArithmeticElements(n, a1, t);
            Console.WriteLine();
            Console.WriteLine("Результат: " + Mult);
        }
    }
}