// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
int num;
do
{
    Console.WriteLine("Введите число");
num = int.Parse(Console.ReadLine());
}
while ((num > 999) || (num<100));

// :10  = 

void SecOfNum (int num)
{
    int num23 = num % 100;
    int num2 = num23 / 10;
    Console.WriteLine($"the second number {num2}");
}
SecOfNum(num);
