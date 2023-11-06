using System;

namespace PZ_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Ввод числа N
                Console.Write("Введите размер массива: ");
                int n = int.Parse(Console.ReadLine());

                // Создание и заполнение массива
                int[] array = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Введите число для индекса {i}: ");
                    array[i] = int.Parse(Console.ReadLine());
                }

                // Поиск четных чисел и их количество
                int k = 0;
                Console.WriteLine("Четные числа в порядке убывания индексов:");
                for (int i = n - 1; i >= 0; i--)
                {
                    if (array[i] % 2 == 0)
                    {
                        Console.WriteLine(array[i]);
                        k++;
                    }
                }

                // Вывод количества четных чисел
                Console.WriteLine($"Количество четных чисел: {k}");

                Console.ReadLine();
            }
        }

    }
