// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.WriteLine("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];
Random ran = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = ran.NextDouble();
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}