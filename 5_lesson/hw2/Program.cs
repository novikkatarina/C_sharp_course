// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] ArrayFill(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 101);
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

int SumOdds(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        count = count + array[i];

    }
    return count;

}
int[] array = ArrayFill(4);
ArrayPrint(array);
Console.WriteLine();
Console.Write(SumOdds(array));