using System;

namespace PZ_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод числа N
            Console.Write("Введите целое число N: ");
            int n = int.Parse(Console.ReadLine());

            // Вычисление двойного факториала
            double doubleFactorial = 1;
            int i = n;
            while (i >= 1)
            {
                doubleFactorial *= i;
                i -= 2;
            }

            // Вывод результата
            Console.WriteLine($"Двойной факториал числа {n}: {doubleFactorial}");

            Console.ReadLine();
        }
    }

}



