
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("третьей цифры нет");
    return;
}
void ThirdOfNum (int num)
{
    int num321 = num % 1000;
    int num3 = num321 / 100;
    Console.WriteLine($"{num3}"); 
}
ThirdOfNum (num);


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
