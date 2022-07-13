// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

void Polindrom (string array)
{
    if (array [0] == array [4] & array [1] == array [3])
    Console.WriteLine ("да");
    else  Console.WriteLine ("нет");
}
string n = Console.ReadLine();
Polindrom (n);
