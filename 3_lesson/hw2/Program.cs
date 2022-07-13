//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.

double XYZ (double x1, double x2, double y1, double y2, double z1, double z2)

{
    return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
}
XYZ (3,2,6,1,8,-7);

Console.WriteLine (XYZ (3,2,6,1,8,-7));



