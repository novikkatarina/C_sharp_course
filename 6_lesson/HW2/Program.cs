// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1,
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
Console.WriteLine("Введите b1, k1, b2, k2");

double[] SetEquation(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}
void CrossOfLines(double[] array)
{
    double x = (array[2] - array[0]) / (array[1] - array[3]);
    double y = array[1]*x + array[0];
    Console.Write($"({x}, {y})");
}

double[] array = SetEquation(4);
CrossOfLines(array);
