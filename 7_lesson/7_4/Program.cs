//Вывести позицию первого найденного элемента, заданного

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
void  FindPosition(int[,] array, int num)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]==num)
            {
                Console.WriteLine($"{i+1},{j+1}");
                return;
            }
        }
    }
    Console.WriteLine("не найдено");
}


int[,] arr_1 = ArrayFill(3, 3, 1, 11);
ArrayPrint(arr_1);
FindPosition(arr_1, -3);
