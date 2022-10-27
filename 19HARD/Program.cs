// напишите программу, которая принимает на вход любое число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine()!);
int final = 0;

int Mirror(int number)
{
    while (number > 0)
    {   
        int number1 = number%10;
        number = number/10;
        final = final*10 + number1;
    }
    Console.Write(final);
    return final;

}

if (Mirror(number) == number)
{
    Console.WriteLine("   Число является палиндромом");
}
else
{
    Console.WriteLine("   Число не является палиндромом");
}

