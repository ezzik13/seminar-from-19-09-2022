// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
using static System.Console;
Clear();
WriteLine("Input Number 1: ");
int a = int.Parse(ReadLine()!);
if (a % 7 == 0 && a % 23 == 0)
{
    WriteLine($"Число {a} кратно 7 и 23");
}
else
{
    WriteLine($"Число {a} не кратно 7 и 23");
}

