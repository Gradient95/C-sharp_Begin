﻿// See https://aka.ms/new-console-template for more information
Console.Write("Введите число - ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.Write("Число чётное");
}
else
{
    Console.Write("Число нечётное");
}