// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] ArrayFill(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    return array;
}

void ArrayPrint(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

double DifferenceMaxMin(double[] array)
{
    double diff = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i ++)
    {
        if (array[i] < min) min = array[i]; 
        if (array[i] > max) max = array[i]; 
    }
    diff = max - min;

 return diff;
 
}
double[] array = ArrayFill(4);
ArrayPrint(array);
Console.WriteLine();
Console.Write(DifferenceMaxMin(array));