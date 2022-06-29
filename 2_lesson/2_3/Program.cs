Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число");
int num2 = int.Parse(Console.ReadLine());

void OneOfNum (int num1, int num2)
{
    if (num2 % num1 == 0)
    {
        Console.WriteLine("Multiple");
    }
    else
    {
        Console.WriteLine($"{num1}, {num2} -> not multiple, the remainder {num2 % num1}");
    }
}
OneOfNum(num1,num2);
// 3. Напишите программу, которая будет принимать 
// на вход два числа и выводить,
//    является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.
