﻿/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.

*/




using System;

public class Answer
{
    public static int SumOfRow(int[,] matrix, int row)
    {
// Введите свое решение ниже
      int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum += matrix[row, i];
    }
    return sum;
    }

    public static int[] MinimumSumRow(int[,] matrix)
    {
// Введите свое решение ниже
     int[] minimumSumRow = new int[2];
       minimumSumRow[0] = 0;
            minimumSumRow[1] = SumOfRow(matrix, 0);
       for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (SumOfRow(matrix, i) < minimumSumRow[1])
        {
            minimumSumRow[0] = i;
            minimumSumRow[1] = SumOfRow(matrix, i);
        }
    }
      return minimumSumRow;
    }

 // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
          // Если аргументы не переданы, используем матрицу по умолчанию
            
            matrix = new int[,]
            {
                {5, 2, 9},
                {8, 1, 4},
                {6, 7, 3}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }

        int[] minSumRow = MinimumSumRow(matrix);

        Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");

        int rowToSum = 1; 
        int sum = SumOfRow(matrix, rowToSum);
        Console.WriteLine($"Сумма элементов в строке {rowToSum + 1}: {sum}");
    }
}