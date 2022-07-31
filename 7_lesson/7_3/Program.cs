//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

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
int SumDiag (int[,] array)
{
    int rows = array.GetLength(0);
    int sum = 0;
    for (int i=0; i < rows; i++)
    {
        sum += array [i,i];
    }
    return sum;
}


int[,] arr_1 = ArrayFill(row, column, 1, 101);
ArrayPrint(arr_1);
Console.WriteLine (SumDiag(arr_1));