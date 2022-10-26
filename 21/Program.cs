// напишите программу, которая на вход принимает координаты двух точек и находит расстояние между ними в 3Д пространстве
// А (3, 6, 8) В (2, 1, -7) = 15,84
// A (7,-5, 0) B (1,-1,9) = 11.53

Console.WriteLine("Введите x А: ");

int xa = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите y A: ");

int ya = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите z A: ");

int za = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите x B: ");

int xb = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите y B: ");

int yb = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите z B: ");

int zb = int.Parse(Console.ReadLine()!);

double Coordination(int xb, int xa, int yb, int ya, int za, int zb)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2));
    return result;

}

Console.WriteLine("Расстояние между точками в пространстве: " + Coordination(xb, xa, yb, ya, za, zb));