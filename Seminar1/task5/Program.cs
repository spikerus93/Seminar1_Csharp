﻿// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"
Console.WriteLine("Введите число N:");
string N = Console.ReadLine();
int a = Convert.ToInt32(N);
for (int i = -a; i <= a; i++)
{
    Console.WriteLine(i);
}
