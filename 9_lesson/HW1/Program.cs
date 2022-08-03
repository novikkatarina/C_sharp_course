// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные 
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void AllEven(int M, int N)
{
    if (N < M) return;
    AllEven(M, N -1);
    if (N % 2 == 0)
        Console.WriteLine(N);
}

AllEven(M, N);