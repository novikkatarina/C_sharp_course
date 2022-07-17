// ПРоизведение пар чисел массива


int[] ArrayFill(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 10);
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

int[] ProductOfNumbersOfArray(int[] array)
{
    int arrLength = array.Length;
    int[] product = new int[arrLength / 2 + arrLength % 2];
    for (int i = 0; i < arrLength / 2; i++)
    {
        product[i] = array[i] * array[arrLength - i - 1];

    }
    if (arrLength % 2 ==1) product[arrLength/2] = array [arrLength/2];

    return product;

}
int[] array = ArrayFill(5);
ArrayPrint(array);
Console.WriteLine();
ArrayPrint(ProductOfNumbersOfArray(array));