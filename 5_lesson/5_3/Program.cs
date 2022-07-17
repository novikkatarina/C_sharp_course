// Присутствует ли значение в массиве


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

void IfNum(int[] array, int num)
{
    string flag = "No";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) {flag = "yes"; break;}
       
    }
 Console.Write($"{num} -> {flag} ");
}
int[] array = ArrayFill(6);
ArrayPrint(array);
Console.WriteLine();
IfNum(array, 4);