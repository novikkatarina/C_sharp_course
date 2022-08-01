// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
int[,] ProductOfArrays(int[,] array1, int[,] array2)
{
    int row_size = array1.GetLength(0);
    int column_size = array1.GetLength(1);
    int[,] product = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            product[i,j] = array1[i,j] * array2[i,j];
        }     
    }   return product;
    Console.WriteLine();

   
}

Console.WriteLine("Enter the number of rows: ");
int row = 4; // int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int column = 4; // int.Parse(Console.ReadLine());

int[,] arr_1 = ArrayFill(row, column, 0, 10);
ArrayPrint(arr_1);
int[,] arr_2 = ArrayFill(row, column, 0, 10);
ArrayPrint(arr_2);
ArrayPrint(ProductOfArrays(arr_1, arr_2));