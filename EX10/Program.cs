// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

using static System.Console;
Clear();
int Number = new Random().Next(100,999+1);
WriteLine(Number);
WriteLine(Number%100/10);