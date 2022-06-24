int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

if (num1 > num3)
{
    if (num1 > num2)
    {
        Console.WriteLine($"{num1} is max");
    }
    else
    {
        Console.WriteLine($"{num2} is max");
    }
}
else if (num2 > num3)
{
    Console.WriteLine($"{num2} is max");

}
else
{
    Console.WriteLine($"{num3} is max");
}