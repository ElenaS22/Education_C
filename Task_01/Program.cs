//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int sqr = number * number;

Console.WriteLine($"Квадрат {number} равен {sqr}");
