// Изменять значения элементов массива на противоположжные


int[] ArrayFill(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
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

void ChangeNum(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
        Console.Write($"{array[i]} ");
    }

}
int[] array = ArrayFill(6);
ArrayPrint(array);
Console.WriteLine();
ChangeNum(array);