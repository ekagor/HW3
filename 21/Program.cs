// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Программа находит расстояние между A и B в 3D пространстве");
Console.Write("Введите x точки A: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите y точки A: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите z точки A: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите x точки B: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите y точки B: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите z точки B: ");
int z2 = int.Parse(Console.ReadLine());
double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
distance = Math.Round(distance, 2);
Console.WriteLine("Расстояние между точками = " + distance);