//Задайте массив из 12 элементов, заполненный случайными числами от [-9, 9]

//Сумма отрицательных и положительных чисел

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

void SumMaxMin(int[] array)
{
    int s_max, s_min;
    s_max = s_min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0) s_max += array[i];
        else s_min += array[i];
    }
    Console.Write($"sum max: {s_max}, sum min: {s_min} ");
}
int[] array = ArrayFill(12);
ArrayPrint(array);
SumMaxMin(array);