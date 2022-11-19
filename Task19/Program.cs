// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using System;
using static System.Console;
Console.Clear();

int a = new Random().Next(10000, 100000);
string str = a.ToString();
int[] b = new int[str.Length];
for( int i=0; i< str.Length; i++)
{
     b[i] = int.Parse(str[i].ToString());
}
if(b[0]==b[4] && b[1]==b[3]) 
{
    WriteLine($"{a} является палиндромом");
}
else
{
    WriteLine($"{a} не является палиндромом");
}
