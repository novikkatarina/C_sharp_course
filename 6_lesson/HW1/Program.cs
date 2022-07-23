// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());

int GratterThan0(int M)
{
    int count = 0;
    double[] array = new double[M];
    for (int i = 0; i < M; i++)
    {

        array[i] = Convert.ToDouble(Console.ReadLine());
        // Console.Write(array[i]);
        if (array[i] > 0) count++;
    }
    return count;
}
Console.Write($"The number is {GratterThan0(M)} ");