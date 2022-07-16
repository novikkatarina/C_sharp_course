// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int MultNum(int A, int B)
	{
	    int all_mult = A;
	    for(int i = 1; i <= B; i++)
	    {
	        all_mult *= i;
	    }
	    return all_mult;
	}
	
	Console.WriteLine(MultNum(2, 2));
	Console.WriteLine(MultNum(4, 3));