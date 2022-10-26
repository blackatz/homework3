// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

Console.WriteLine("Двухмерное или трехмерное пространство? Введите цифру");

int location = int.Parse(Console.ReadLine()!);


if (location == 3)
{

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
}

if (location == 2)
{
  Console.WriteLine("Введите x А: ");

int xa2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите y A: ");

int ya2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите x B: ");

int xb2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите y B: ");

int yb2 = int.Parse(Console.ReadLine()!);

double Coordination2(int xb2, int xa2, int yb2, int ya2)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow((xa2 - xb2), 2) + Math.Pow((ya2 - yb2), 2));
    return result;

}

Console.WriteLine("Расстояние между точками: " + Coordination2(xb2, xa2, yb2, ya2));
}