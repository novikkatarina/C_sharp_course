// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void Sequence(int M, int N, int sum)
{
    sum += N;
    if (N < M)
    {
        Console.Write($"{sum}");
        return;
    }
    Sequence(M, N - 1, sum);
}
Sequence(M, N, 0);