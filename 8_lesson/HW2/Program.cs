// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
int Sum(int[,] array)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    int minrow  = 0;
    int min = 99999;
    for (int i = 0; i < row_size; i++)
    {

        int sum = 0;
        for (int j = 0; j < column_size; j++)
        {
            sum += array[i,j];
        }
        if (sum < min)
        {
            minrow = i;
            min = sum;
        }
     
    }   return minrow;
    Console.WriteLine();

   
}


Console.WriteLine("Enter the number of rows: ");
int row = 4; // int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int column = 4; // int.Parse(Console.ReadLine());

int[,] arr_1 = ArrayFill(row, column, 0, 10);
ArrayPrint(arr_1);
Console.WriteLine($"{Sum(arr_1)} строка");