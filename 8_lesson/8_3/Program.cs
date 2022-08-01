// 3. Составить частотный словарь элементов двумерного массива.
//    Частотный словарь содержит информацию о том, сколько раз 
//    встречается элемент входных данных. Значения элементов массива 0..9
int[] Vocabulary(int[,] arr)
{
    int[] array = new int[10];
    foreach (int item in arr) array[item]++;
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
      
        Console.Write($"{i} - {arr[i]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);
int[] array_1 = Vocabulary(arr_1);
PrintArray(array_1);
