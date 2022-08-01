// Задайте двумерный массив из целых чисел. Напишите пр
// ограмму, которая удалит строку и столбец, на пересечении которых расположен наименьший 
// элемент массива.

void ArrayPrint(int[,] array)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($"{array[i, j]} \t");
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
int[] CoordinatesOfMinNUmber(int[,] array)
{
    int[] ArrayCoordinates = new int[2];
    int min = 9999;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                ArrayCoordinates[0] = i;
                ArrayCoordinates[1] = j;

            }
        }

    }Console.WriteLine($"{ArrayCoordinates[0]},{ArrayCoordinates[1]}");
    return ArrayCoordinates;
}
void PrintWhithoutMin(int[,] array, int[] ArrayCoordinates)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            if ((i != ArrayCoordinates[0]) && (j != ArrayCoordinates[1]))
            {
                Console.Write($"{array[i, j]} \t");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Enter the number of rows: ");
int row = 4; //int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int column = 4; //int.Parse(Console.ReadLine());

int[,] arr_1 = ArrayFill(row, column, 0, 100);
ArrayPrint(arr_1);
int[] Coordinates = CoordinatesOfMinNUmber(arr_1);
PrintWhithoutMin(arr_1, Coordinates);