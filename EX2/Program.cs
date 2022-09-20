// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число не кратно
// числу первому, то программа выводит остаток от деления.

using static System.Console;

Clear();

WriteLine("Input Number 1: ");
int a = int.Parse(ReadLine()!);
WriteLine("Input Number 2: ");
int b = int.Parse(ReadLine()!);
if (b > a)
{
    int temp = a;
    a = b;
    b = temp;
}
if (a % b == 0)
{
    WriteLine($"Число {a} кратно {b}");
}
else
    WriteLine($"Остаток от деления = {a % b}");

// if(y==0) return; 
// if (x%y==0) WriteLine("кратно"); 
// if (x%y!=0) WriteLine($"не кратно, остаток {x%y}");
