// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void ArrayPrint(int[,] array)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] ArrayFill(int row, int columns, int from, int to)
{
    int[,] array = new int[row, columns];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(from, to);
        }
    }
    return array;
}
void NumberOfPosition (int[,] array, int m,int n)

{

    if (m > array.GetLength(0) && n > array.GetLength(1))
    {
        Console.WriteLine("There is not such position");
        return;
    }
    Console.WriteLine($"{m},{n} - > {array[m-1,n-1]}");
}

Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the row of a number: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the columnof a number: ");
int n = int.Parse(Console.ReadLine());

int[,] arr_1 = ArrayFill(row, column, 0, 10);
ArrayPrint(arr_1);
NumberOfPosition (arr_1, m, n);
