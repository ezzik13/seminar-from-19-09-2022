// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

using static System.Console;

Clear();

WriteLine("Input Number 1: ");

int a = int.Parse(ReadLine()!);

if (a/100 > 0)
{
    WriteLine($"третья цифра введенного числа {a} равна {a%1000/100}");
}
else
{
    WriteLine("У введенного числа нет третьей цифры");
}