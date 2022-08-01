// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Например, задан массив:
// 3 10 7 3
// 1 5 9 3
// 8 4 7 0
// 7 1 9 3
// В итоге получается вот такой массив:
// 10 7 3 3
// 9 5 3 1
// 8 7 4 0
// 9 7 3 1

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
int[,] MaxToMin(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count = 0;
        do
        {

            for (int j = 1; j < array.GetLength(1); j++)
            {

                if (array[i, j - 1] < array[i, j])

                {
                    int n = array[i, j];
                    array[i, j] = array[i, j - 1];
                    array[i, j-1] = n;
                }
            }
            count++;
        } while (count != array.GetLength(1) - 1);
    }
    Console.WriteLine();
    return array;
}

Console.WriteLine("Enter the number of rows: ");
int row = 4; // int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int column = 4; // int.Parse(Console.ReadLine());

int[,] arr_1 = ArrayFill(row, column, 0, 10);
ArrayPrint(arr_1);
ArrayPrint(MaxToMin(arr_1));