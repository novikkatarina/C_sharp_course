// 123 элементов массива, сколько элементов лежат в отрезке [10,99]


int[] ArrayFill(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99, 99);
    }
    return array;
}

void ArrayPrint(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int CountNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 100 & array[i] > 9) count += 1;
       
    }
 return count;
 
}
int[] array = ArrayFill(123);
ArrayPrint(array);
Console.WriteLine();
Console.Write(CountNumbers(array));