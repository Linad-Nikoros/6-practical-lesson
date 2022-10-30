﻿// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Write("Введите k1: ");
int k1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
int b1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 =Convert.ToInt32(Console.ReadLine());
if ((k1 == k2) && (b1 == b2)) Console.Write("Прямые лежат друг на друге ");
else if (k1==k2) Console.WriteLine ("Прямые параллельны");
else
{
int x =(b2 - b1)/(k1 - k2);
int y =k1*x+b1;
Console.WriteLine($"Координаты точки пересечения ({x};{y})");
}