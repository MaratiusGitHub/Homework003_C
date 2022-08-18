// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void lenght_AB(double a1, double b1, double c1, double a2, double b2, double c2)
{
    double l = Math.Round(Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2) + Math.Pow(c2 - c1, 2)), 2);
    Console.WriteLine($"Расстояние между точками =  {l}");
}

Console.WriteLine("Введите координаты первой точки");

Console.Write("x = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z = ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");

Console.Write("x = ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z = ");
double z2 = Convert.ToDouble(Console.ReadLine());

lenght_AB(x1, y1, z1, x2, y2, z2);