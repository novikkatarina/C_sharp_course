// на вход число N, на выходе таблицу квадратов этих чисел

void Pows (int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.Write ($"{Math.Pow (count, 2)} ");
        count ++;
    }
}
Pows (4);