int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num1<num2)
{
    Console.WriteLine($"{num1} is min, {num2} is max");
}
else if (num1>num2)
{
    Console.WriteLine($"{num2} is min, {num1} is max");
}
else 
{
    Console.WriteLine("They are equal");
}
