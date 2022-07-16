// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumNum(int A)
	{
        int sum = 0;
        while (A > 0)
        {
           sum = sum + A % 10;
           A = A / 10;
        }
	    return sum;
	}
	
	Console.WriteLine(SumNum(4456));
	Console.WriteLine(SumNum(11111));