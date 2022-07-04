int num = int.Parse(Console.ReadLine());

int N = 2;

if (num < 2)
{
    Console.WriteLine($"{num} is not big enough");
return;}

while (N <= num)
{
    Console.WriteLine($"{N}");
    N +=2;

    }
    