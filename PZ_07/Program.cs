using System;

namespace PZ_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Random random = new Random();

                // Создание и заполнение двумерного массива рандомными значениями
                double[,] matrix = new double[8, 6];
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        matrix[i, j] = random.NextDouble() * 100; // Генерация случайного числа от 0 до 100
                    }
                }

                // Вывод двумерного массива
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine($"Значение элемента для индексов [{i}, {j}]: {matrix[i, j]}");
                    }
                }

                // Поиск минимального элемента
                double minElement = matrix[0, 0];
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (matrix[i, j] < minElement)
                        {
                            minElement = matrix[i, j];
                        }
                    }
                }

                // Вычисление суммы положительных элементов
                double sumPositiveElements = 0;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (matrix[i, j] > 0)
                        {
                            sumPositiveElements += matrix[i, j];
                        }
                    }
                }

                // Вычисление произведения минимального элемента на сумму положительных элементов
                double result = minElement * sumPositiveElements;

                // Вывод результата
                Console.WriteLine($"Произведение минимального элемента на сумму положительных элементов: {result}");

                Console.ReadLine();
            }
        }

    }
    