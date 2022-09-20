// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

using static System.Console;  
Clear(); 
WriteLine("Input Number 1: "); 
int a = int.Parse(ReadLine()!); 
WriteLine("Input Number 2: "); 
int b = int.Parse(ReadLine()!); 
if(b>a) 
{     
    int temp = a;     
    a = b;     
    b = temp; 
    } 
//if(a == b*b) 
// { //     WriteLine("Одно число является квадратом другого");
// }
// else
// WriteLine("Одно число не является квадратом другого");

// if (Math.Pow(a,0.5) == b)


if(Math.Sqrt(a)==b)
{
WriteLine("Одно число является квадратом другого");
}
else
WriteLine("Одно число не является квадратом другого");
