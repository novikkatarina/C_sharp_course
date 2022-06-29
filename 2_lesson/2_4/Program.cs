// 4. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());


void OneOfNum (int num1)
{
    if (num % 7 == 0 && num1 % 23 == 0)
    {
        Console.WriteLine("Multiple");
    }
    else
    {
        Console.WriteLine("not multiple");
    }
}
OneOfNum(num);