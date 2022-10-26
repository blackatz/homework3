// напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// 14212 - нет
// 12821 - да

Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine()!);

int Mirror(int number)
{
    // int one = number/10000;
    // int two = number%10000/1000;
    // int three = number%1000/100;
    // int four = number%100/10;
    // int five = number%10;
    int sum = number/10000 + number%10000/1000*10 + number%1000/100*100 + number%100/10*1000 + number%10*10000;
    return sum;
}

if (Mirror(number) == number)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}