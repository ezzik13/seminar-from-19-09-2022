// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

using static System.Console;
Clear();
int Number = new Random().Next(100,999+1);
// WriteLine(Number);
// int a = Number/100;
// int b = Number%10;
// WriteLine($"{a*10+b}");
WriteLine(Number);
string new_number = Convert.ToString(Number/100) + Convert.ToString(Number%10);
WriteLine(new_number);
