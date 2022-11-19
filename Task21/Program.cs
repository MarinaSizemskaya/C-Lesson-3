// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

using System;
using static System.Console;
Console.Clear();
Write("Введите координату X точки А: ");
int x1 = int.Parse(ReadLine());
Write("Введите координату Y точки A: ");
int y1 = int.Parse(ReadLine());
Write("Введите координату Z точки A: ");
int z1 = int.Parse(ReadLine());
Write("Введите координату X точки B: ");
int x2 = int.Parse(ReadLine());
Write("Введите координату Y точки B: ");
int y2 = int.Parse(ReadLine());
Write("Введите координату Z точки B: ");
int z2 = int.Parse(ReadLine());

double d = Math.Sqrt(Math.Pow((x1 - x2), 2)+Math.Pow((y1 - y2), 2)+Math.Pow((z1-z2),2));
WriteLine($"Длина отрезка = {d:f2}");