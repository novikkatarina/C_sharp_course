// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

void NumRandom ()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine($"{num} - > {num / 100}{num % 10}");

}
NumRandom();