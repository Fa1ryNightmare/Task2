using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите K: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            double S = 0;
            for (int n = 0; n <= k; n++)
            {
                S += Math.Pow(-1, n) * (Math.Pow(x, 2 * n + 1) / ((2 * n - 1) * Fact(2 * n + 1)));
            }
            Console.WriteLine($"Сумма ряда: {S}");
        }
        static int Fact(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
