﻿// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет
//Console.Clear();

Console.WriteLine("Введите число a");

int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число b");

int b = int.Parse(Console.ReadLine()!);

if (a == b * b)
{
    Console.WriteLine("Да, число а является квадратом числа b");
}
else
{
    Console.WriteLine("нет, это не квадрат числа b");
}
