﻿//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void ArrayPrint(double[,] array)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
double[,] ArrayFill(int row, int columns, int from, int to)
{
    double[,] array = new double[row, columns];
    Random n_new = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            var d = n_new.NextDouble()* (to - from) + from;
            array[i, j] = Math.Round(d, 2);
        }
    }
    return array;
}

Console.WriteLine("Enter the number of rows: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int n = int.Parse(Console.ReadLine());

double[,] arr_1 = ArrayFill(m, n, -10, 10);
ArrayPrint(arr_1);
