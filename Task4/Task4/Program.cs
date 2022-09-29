using System;

namespace Task3
{
    class Program
    {
        static double SumGeometricElements(int alim, double a, double t)
        {
            double sum = a;
            while (alim < a)
            {
                a = a * t;
                if(a>alim) 
                    sum = sum + a;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите alim: ");
            int alim = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите a1: ");
            double a1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите t: ");
            double t = Double.Parse(Console.ReadLine());

            double sum = SumGeometricElements(alim, a1, t);
            Console.WriteLine();
            Console.WriteLine("Результат: " + sum);
        }
    }
}