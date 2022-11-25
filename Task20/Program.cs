// Задача 20: Напишите программу, 
// которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты двух точек: ");
Console.Write("Введите координаты x точки A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y точки A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты x точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());

double Distance(int ax, int ay, int bx, int by)
{
    return Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
}

double result = Math.Round(Distance(xA, yA, xB, yB), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками: {result}");
