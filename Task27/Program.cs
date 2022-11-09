// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите натуральное число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Сумма цифр данного числа: {SumDigit(number)}");

int SumDigit(int x)
{
    int summ = 0;
    while (x > 0)
    {
        summ = summ + x % 10;
        x = x / 10;
    }
    return summ;
}

