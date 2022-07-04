
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("третьей цифры нет");
    return;
}

int num3 = num % 1000;
Console.WriteLine($"{num3}");


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// while ((num > 999) || (num<100));

// // :10  = 

// void SecOfNum (int num)
// {
//     int num23 = num % 100;
//     int num2 = num23 / 10;
//     Console.WriteLine($"the second number {num2}");
// }
// SecOfNum(num);