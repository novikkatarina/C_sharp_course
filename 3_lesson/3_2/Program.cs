﻿//Напишите программу, которая принимает на вход номер четвертьи, а на выходе диапазон

void Quarter(int num)
{
    if (num == 1) Console.WriteLine("x > 0, y > 0");
    else if (num == 2) Console.WriteLine("x < 0, y > 0");
    else if (num == 3) Console.WriteLine("x < 0, y < 0");
    else if (num == 4) Console.WriteLine("x > 0, y < 0");
    else Console.WriteLine("не верно");
}
Quarter(0);
Quarter(1);
Quarter(2);
