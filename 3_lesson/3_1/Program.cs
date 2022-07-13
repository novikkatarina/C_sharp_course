
//Напишите программу, которая принимает на вход x и y и выдает четверть, x не равно нулю или y не равно нулю

void Quarter(int x, int y)
{
    if (x == 0 || y == 0) Console.WriteLine("x=0, y=0");
    else if (x > 0 & y > 0) Console.WriteLine("I");
    else if (x < 0 & y > 0) Console.WriteLine("II");
    else if (x < 0 & y < 0) Console.WriteLine("III");
    else if (x > 0 & y < 0) Console.WriteLine("IV");
}
Quarter(0, 0);
Quarter(1, 2);
Quarter(-1, 2);
Quarter(-1, -2);
Quarter(1, -2);