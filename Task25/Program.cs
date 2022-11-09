// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
Console.WriteLine("Введите число А: ");
double a = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите натуральное число B: ");
int b = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"{a} в степени {b} = {Exponentiate(a, b)}");

double Exponentiate(double x, int y)
{
    double exp = 1;
    for(int i = 1; i <= y; i++)
    {
        exp = exp*x;
    }
    return exp;
}


