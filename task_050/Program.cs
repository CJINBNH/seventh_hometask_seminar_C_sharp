// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

 Console.Clear();

Console.WriteLine("Введите строку a: ");
int a = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите столбец b: ");
int b = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n: ");
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
    Console.WriteLine("Исходный массив:");
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = ran.Next(10, 99);
        Console.Write("{0} ", matrix[i, j]);
    }
    Console.WriteLine();
}
if (a < 0 | a > matrix.GetLength(0) - 1 | b < 0 | b > matrix.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", matrix[a, b]);
}
Console.ReadLine();

// Console.WriteLine("Введите количество строк m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[m, n];
// Random ran = new Random();
// int z = 0;


// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matrix[i, j] = ran.Next(1, 10);
//         Console.Write(matrix[i, j] + " ");
//         if (matrix[i, j] > z)
//         {
//             z = matrix[i, j];
//         }
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите число для проверки: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// if (number <= z)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             if (number == matrix[i, j])
//             {
//                 count += 1;
//                 break;
//             }
//         }
//     }
//     if (count != 0)
//     {
//         Console.WriteLine($"Число {number} встречается в массиве");
//     }
//     else Console.WriteLine($"Число {number} в массиве отсутствует");
//     count = 0;
// }
// else Console.WriteLine($"Число {number} в массиве отсутствует");