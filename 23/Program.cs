﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число для возведения в куб: ");

int n = int.Parse(Console.ReadLine()!);

void Square(int n)
{
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i} ^ 3 = {i * i * i}");
}
}

Console.WriteLine("Итог: ");
Square(n);