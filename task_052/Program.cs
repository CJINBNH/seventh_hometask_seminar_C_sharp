﻿// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.WriteLine("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
Random ran = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = ran.Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("-------");
// Console.WriteLine(matrix.GetLength(0));

double result = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
        result = sum / matrix.GetLength(0);
    }
    Console.Write($"{Math.Round(result, 2)} ");
}
Console.ReadLine();