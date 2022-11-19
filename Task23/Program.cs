// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using System;
using static System.Console;
Console.Clear();

Write("Введите число: ");
int N = int.Parse(ReadLine());
int X = 1;
// while(X<=N)
// {
//     Write($"{X*X*X} ");
//     X++;
// }
for(int i=1; i<=N; i++)
{
    Write($"{i*i*i} ");
}